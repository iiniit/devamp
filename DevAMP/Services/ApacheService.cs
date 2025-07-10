using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevAMP.Services
{
    internal class ApacheService
    {
        public void InitiateApache(string appPath, string apachePath, string htdocsPath, string phpPath, string mysqlPath, string phpMyAdminPath, string apacheHttpdPath, string apacheDevampConfPath)
        {
            string httpdConfigContent = ResourceHelper.GetEmbeddedResourceContent("Config.httpd.conf");
            httpdConfigContent = httpdConfigContent
                .Replace("{{APACHE_PATH}}", apachePath)
                .Replace("{{HTDOCS_PATH}}", htdocsPath);

            string devampConfigContent = ResourceHelper.GetEmbeddedResourceContent("Config.httpd-devamp.conf");
            devampConfigContent = devampConfigContent
                .Replace("{{APP_PATH}}", appPath)
                .Replace("{{PHPMYADMIN_PATH}}", phpMyAdminPath)
                .Replace("{{PHP_PATH}}", phpPath)
                .Replace("{{MYSQL_PATH}}", mysqlPath)
                .Replace("{{APACHE_PATH}}", apachePath);

            File.WriteAllText(apacheHttpdPath, httpdConfigContent);
            File.WriteAllText(apacheDevampConfPath, devampConfigContent);
        }

        public (int pid, int port) StartApache(string apacheDirectory)
        {
            int port = GetListenPort(apacheDirectory);
            string exePath = Path.Combine(apacheDirectory, "bin", "httpd.exe");

            if (!File.Exists(exePath))
            {
                throw new FileNotFoundException($"Apache not found at: {exePath}");
            }

            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = exePath,
                    UseShellExecute = true,
                    CreateNoWindow = false,
                    WindowStyle = ProcessWindowStyle.Hidden,
                }
            };

            process.Start();
            int pid = process.Id;

            return (pid, port);
        }

        public int GetListenPort(string apacheDirectory)
        {
            string confPath = Path.Combine(apacheDirectory, "conf", "httpd.conf");
            if (!File.Exists(confPath))
                return 80; // Default port

            foreach (string line in File.ReadAllLines(confPath))
            {
                string trimmed = line.Trim();
                if (trimmed.StartsWith("#")) continue;

                Match match = Regex.Match(trimmed, @"^Listen\s+(\d+)");
                if (match.Success)
                {
                    return int.Parse(match.Groups[1].Value);
                }
            }

            return 80;
        }

        public void StopApache()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "taskkill",
                Arguments = "/F /IM httpd.exe",
                CreateNoWindow = true,
                UseShellExecute = false
            });
        }
    }
}
