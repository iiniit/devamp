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
    internal class FilezillaService
    {
        public void Stop()
        {
            var psi = new ProcessStartInfo
            {
                FileName = "taskkill",
                Arguments = "/F /IM FileZillaServer.exe",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            Process.Start(psi)?.WaitForExit();
        }

        private int GetPort(string filezillaPath)
        {
            string configPath = Path.Combine(filezillaPath, "FileZilla Server.xml");

            if (!File.Exists(configPath))
                return 21; // default FTP port

            foreach (var line in File.ReadLines(configPath))
            {
                var match = Regex.Match(line, @"<Port>(\d+)</Port>");
                if (match.Success)
                    return int.Parse(match.Groups[1].Value);
            }

            return 21; // fallback default
        }
        public (int pid, int port) Start(string filezillaPath)
        {
            Stop();

            string exePath = Path.Combine(filezillaPath, "FileZillaServer.exe");
            if (!File.Exists(exePath))
                throw new FileNotFoundException($"FileZilla Server not found at: {exePath}");

            var psi = new ProcessStartInfo
            {
                FileName = exePath,
                UseShellExecute = true,
                CreateNoWindow = false,
                //WindowStyle = ProcessWindowStyle.Hidden,
            };

            Process process = Process.Start(psi);
            if (process == null)
                throw new Exception("Failed to start FileZilla Server.");

            int port = GetPort(filezillaPath);
            return (process.Id, port);
        }
    }
}
