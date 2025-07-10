using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DevAMP.Services
{
    internal class MySQLService
    {
        public void InitiateMySQL(string appPath, string mysqlConfigPath)
        {
            string mysqlConfigContent = ResourceHelper.GetEmbeddedResourceContent("Config.my.ini");

            mysqlConfigContent = mysqlConfigContent
                .Replace("{{APP_PATH}}", appPath.Replace("\\", "/"));

            File.WriteAllText(mysqlConfigPath, mysqlConfigContent);
        }

        public int GetPort(string mysqlBasePath)
        {
            string configFile = Path.Combine(mysqlBasePath, "my.ini");
            if (!File.Exists(configFile))
                return 3306;

            foreach (var line in File.ReadLines(configFile))
            {
                string trimmed = line.Trim();
                var match = Regex.Match(trimmed, @"^port\s*=\s*(\d+)", RegexOptions.IgnoreCase);
                if (match.Success)
                    return int.Parse(match.Groups[1].Value);
            }
            return 3306;
        }

        public void Stop()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "taskkill",
                Arguments = "/F /IM mysqld.exe",
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            })?.WaitForExit();
        }

        public (int pid, int port) Start(string mysqlBasePath)
        {
            int port = GetPort(mysqlBasePath);

            string exePath = Path.Combine(mysqlBasePath, "bin", "mysqld.exe");
            if (!File.Exists(exePath))
                throw new FileNotFoundException($"MySQL executable not found: {exePath}");

            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = exePath,
                    Arguments = $"--defaults-file=\"{Path.Combine(mysqlBasePath, "my.ini")}\" --standalone --console",
                    UseShellExecute = true,
                    CreateNoWindow = false,
                    WindowStyle = ProcessWindowStyle.Hidden,
                }
            };

            process.Start();
            if (process == null)
                throw new Exception("Failed to start mysqld.exe");

            return (process.Id, port);
        }
    }
}
