using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeTai_QuanLySinhVien
{
    internal static class DatabaseBootstrap
    {
        private const string DatabaseName = "QuanLySinhVien";

        public static bool Initialize()
        {
            string workingConnectionString;
            string detailMessage;

            if (TryPrepareDatabase(out workingConnectionString, out detailMessage))
            {
                Properties.Settings.Default["QuanLySinhVienConnectionString"] = workingConnectionString;
                return true;
            }

            MessageBox.Show(
                "Không kết nối được cơ sở dữ liệu QuanLySinhVien.\n\n" +
                detailMessage +
                "\n\nCách xử lý nhanh:\n" +
                "1. Mở SQL Server/SQL Server Express hoặc LocalDB.\n" +
                "2. Restore file DB\\QuanLySinhVien.bak thành database QuanLySinhVien.\n" +
                "3. Chạy lại chương trình.\n\n" +
                "Nếu bạn chạy bằng Visual Studio, hãy để project ở đường dẫn ngắn, ngoài OneDrive.",
                "Lỗi cơ sở dữ liệu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return false;
        }

        private static bool TryPrepareDatabase(out string workingConnectionString, out string detailMessage)
        {
            List<string> errors = new List<string>();

            foreach (string serverName in GetServerCandidates())
            {
                try
                {
                    using (SqlConnection master = new SqlConnection(BuildMasterConnectionString(serverName)))
                    {
                        master.Open();

                        if (DatabaseExists(master))
                        {
                            EnsureCurrentLoginCanUseDatabase(master);

                            string existingDbConnection = BuildDatabaseConnectionString(serverName);
                            if (CanOpenDatabase(existingDbConnection, out detailMessage))
                            {
                                workingConnectionString = existingDbConnection;
                                return true;
                            }
                        }

                        string backupPath = FindBackupPath();
                        if (!string.IsNullOrWhiteSpace(backupPath) && File.Exists(backupPath))
                        {
                            string restoreError;
                            if (TryRestoreDatabase(master, backupPath, out restoreError))
                            {
                                EnsureCurrentLoginCanUseDatabase(master);

                                string restoredDbConnection = BuildDatabaseConnectionString(serverName);
                                if (CanOpenDatabase(restoredDbConnection, out detailMessage))
                                {
                                    workingConnectionString = restoredDbConnection;
                                    return true;
                                }
                            }
                            else if (!string.IsNullOrWhiteSpace(restoreError))
                            {
                                errors.Add(serverName + ": " + restoreError);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    errors.Add(serverName + ": " + ex.Message);
                }
            }

            workingConnectionString = null;
            detailMessage = BuildErrorMessage(errors);
            return false;
        }

        private static IEnumerable<string> GetServerCandidates()
        {
            string machine = Environment.MachineName;
            return new[]
            {
                @".\SQLEXPRESS",
                @".",
                @"(localdb)\MSSQLLocalDB",
                @"localhost\SQLEXPRESS",
                @"localhost",
                machine + @"\SQLEXPRESS",
                machine
            }.Distinct(StringComparer.OrdinalIgnoreCase);
        }

        private static string BuildMasterConnectionString(string serverName)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = serverName;
            builder.InitialCatalog = "master";
            builder.IntegratedSecurity = true;
            builder.ConnectTimeout = 3;
            return builder.ConnectionString;
        }

        private static string BuildDatabaseConnectionString(string serverName)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = serverName;
            builder.InitialCatalog = DatabaseName;
            builder.IntegratedSecurity = true;
            builder.ConnectTimeout = 3;
            return builder.ConnectionString;
        }

        private static bool DatabaseExists(SqlConnection master)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM sys.databases WHERE name = @db", master))
            {
                cmd.Parameters.AddWithValue("@db", DatabaseName);
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result) > 0;
            }
        }

        private static void EnsureCurrentLoginCanUseDatabase(SqlConnection master)
        {
            if (!DatabaseExists(master))
            {
                return;
            }

            string sql = @"
DECLARE @login sysname = SUSER_SNAME();
IF @login IS NOT NULL
BEGIN
    DECLARE @escapedLogin nvarchar(512) = REPLACE(@login, ']', ']]');
    DECLARE @sql nvarchar(max) =
        N'USE [QuanLySinhVien]; ' +
        N'IF NOT EXISTS (SELECT 1 FROM sys.database_principals WHERE name = N''' + @escapedLogin + N''') ' +
        N'BEGIN CREATE USER [' + @escapedLogin + N'] FOR LOGIN [' + @escapedLogin + N']; END; ' +
        N'IF NOT EXISTS (SELECT 1 FROM sys.database_role_members rm JOIN sys.database_principals r ON rm.role_principal_id = r.principal_id JOIN sys.database_principals m ON rm.member_principal_id = m.principal_id WHERE r.name = N''db_owner'' AND m.name = N''' + @escapedLogin + N''') ' +
        N'BEGIN ALTER ROLE [db_owner] ADD MEMBER [' + @escapedLogin + N']; END;';
    EXEC(@sql);
END";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, master))
                {
                    cmd.CommandTimeout = 15;
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
            }
        }

        private static bool CanOpenDatabase(string connectionString, out string errorMessage)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    errorMessage = null;
                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        private static string FindBackupPath()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string[] candidates = new[]
            {
                Path.Combine(baseDir, "QuanLySinhVien.bak"),
                Path.Combine(baseDir, "database", "QuanLySinhVien.bak"),
                Path.Combine(baseDir, "..", "database", "QuanLySinhVien.bak"),
                Path.Combine(baseDir, "..", "..", "database", "QuanLySinhVien.bak"),
                Path.Combine(baseDir, "..", "..", "..", "database", "QuanLySinhVien.bak"),
                Path.Combine(baseDir, "..", "..", "..", "..", "database", "QuanLySinhVien.bak")
            };

            return candidates
                .Select(path => Path.GetFullPath(path))
                .FirstOrDefault(File.Exists);
        }

        private static bool TryRestoreDatabase(SqlConnection master, string backupPath, out string errorMessage)
        {
            errorMessage = null;

            try
            {
                DataTable fileList = new DataTable();
                using (SqlCommand cmd = new SqlCommand("RESTORE FILELISTONLY FROM DISK = @bak", master))
                {
                    cmd.Parameters.AddWithValue("@bak", backupPath);
                    cmd.CommandTimeout = 60;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(fileList);
                    }
                }

                DataRow dataRow = fileList.AsEnumerable().FirstOrDefault(r => string.Equals(Convert.ToString(r["Type"]), "D", StringComparison.OrdinalIgnoreCase));
                DataRow logRow = fileList.AsEnumerable().FirstOrDefault(r => string.Equals(Convert.ToString(r["Type"]), "L", StringComparison.OrdinalIgnoreCase));

                if (dataRow == null || logRow == null)
                {
                    errorMessage = "Không đọc được logical name từ file backup.";
                    return false;
                }

                string dataPath = GetDefaultFolder(master, true);
                string logPath = GetDefaultFolder(master, false);
                string dataFile = Path.Combine(dataPath, DatabaseName + ".mdf");
                string logFile = Path.Combine(logPath, DatabaseName + "_log.ldf");

                string logicalDataName = Convert.ToString(dataRow["LogicalName"]);
                string logicalLogName = Convert.ToString(logRow["LogicalName"]);

                string bakLiteral = EscapeSqlLiteral(backupPath);
                string logicalDataLiteral = EscapeSqlLiteral(logicalDataName);
                string logicalLogLiteral = EscapeSqlLiteral(logicalLogName);
                string dataFileLiteral = EscapeSqlLiteral(dataFile);
                string logFileLiteral = EscapeSqlLiteral(logFile);

                StringBuilder sql = new StringBuilder();
                sql.AppendLine("IF DB_ID(N'" + DatabaseName + "') IS NOT NULL BEGIN");
                sql.AppendLine("    ALTER DATABASE [" + DatabaseName + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;");
                sql.AppendLine("END");
                sql.AppendLine("RESTORE DATABASE [" + DatabaseName + "]");
                sql.AppendLine("FROM DISK = N'" + bakLiteral + "'");
                sql.AppendLine("WITH REPLACE,");
                sql.AppendLine("MOVE N'" + logicalDataLiteral + "' TO N'" + dataFileLiteral + "',");
                sql.AppendLine("MOVE N'" + logicalLogLiteral + "' TO N'" + logFileLiteral + "',");
                sql.AppendLine("RECOVERY;");
                sql.AppendLine("ALTER DATABASE [" + DatabaseName + "] SET MULTI_USER;");

                using (SqlCommand restoreCmd = new SqlCommand(sql.ToString(), master))
                {
                    restoreCmd.CommandTimeout = 180;
                    restoreCmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        private static string EscapeSqlLiteral(string value)
        {
            return (value ?? string.Empty).Replace("'", "''");
        }

        private static string GetDefaultFolder(SqlConnection master, bool dataFile)
        {
            string propertyQuery = dataFile
                ? "SELECT CAST(SERVERPROPERTY('InstanceDefaultDataPath') AS nvarchar(4000))"
                : "SELECT CAST(SERVERPROPERTY('InstanceDefaultLogPath') AS nvarchar(4000))";
            string fallbackQuery = dataFile
                ? "SELECT TOP 1 physical_name FROM master.sys.database_files WHERE file_id = 1"
                : "SELECT TOP 1 physical_name FROM master.sys.database_files WHERE file_id = 2";

            using (SqlCommand cmd = new SqlCommand(propertyQuery, master))
            {
                object value = cmd.ExecuteScalar();
                string path = Convert.ToString(value);
                if (!string.IsNullOrWhiteSpace(path))
                {
                    return path;
                }
            }

            using (SqlCommand cmd = new SqlCommand(fallbackQuery, master))
            {
                object value = cmd.ExecuteScalar();
                string physicalName = Convert.ToString(value);
                if (!string.IsNullOrWhiteSpace(physicalName))
                {
                    return Path.GetDirectoryName(physicalName);
                }
            }

            return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        }

        private static string BuildErrorMessage(List<string> errors)
        {
            if (errors == null || errors.Count == 0)
            {
                return "Không tìm thấy SQL Server phù hợp hoặc file backup chưa sẵn sàng.";
            }

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Chi tiết đã thử:");
            foreach (string item in errors.Take(6))
            {
                builder.AppendLine("- " + item);
            }

            if (errors.Count > 6)
            {
                builder.AppendLine("- ...");
            }

            return builder.ToString();
        }
    }
}
