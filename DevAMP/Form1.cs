using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using DevAMP.Services;

namespace DevAMP
{
    public partial class Form1 : Form
    {
        private string appPath;

        // htdocs
        private string htdocsPath;

        // Apache
        private string apachePath;
        private string apacheHttpdPath;
        private string apacheDevampConfPath;

        // phpmyadmin path
        private string phpMyAdminPath;

        // PHP
        private string phpPath;
        private string phpConfigPath;

        // MySQL
        private string mysqlPath;
        private string mysqlConfigPath;

        // Filezilla
        private string filezillaPath;

        private ApacheService apacheService;
        private MySQLService mySQLService;
        private PHPService phpservice;
        private FilezillaService filezillaService;

        public Form1()
        {
            InitializeComponent();
            initiatePath();

            apacheService = new ApacheService();
            mySQLService = new MySQLService();
            phpservice = new PHPService();
            filezillaService = new FilezillaService();

            bool isInitiate = Properties.Settings.Default.isInitiate;
            if (!isInitiate)
            {
                apacheService.InitiateApache(appPath, apachePath, htdocsPath, phpPath, mysqlPath, phpMyAdminPath, apacheHttpdPath, apacheDevampConfPath);
                mySQLService.InitiateMySQL(appPath, mysqlConfigPath);
                phpservice.InitiatePHP(phpPath, phpConfigPath);
                Properties.Settings.Default.isInitiate = true;
                Properties.Settings.Default.Save();
            }
        }

        private void initiatePath()
        {
            appPath = AppDomain.CurrentDomain.BaseDirectory;
            appPath = appPath.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);

            // htdocs
            htdocsPath = Path.Combine(appPath, "htdocs");

            // apache
            apachePath = Path.Combine(appPath, "apache");
            apacheHttpdPath = Path.Combine(apachePath, "conf", "httpd.conf");
            apacheDevampConfPath = Path.Combine(apachePath, "conf", "extra", "httpd-devamp.conf");

            // phpmyadmin
            phpMyAdminPath = Path.Combine(appPath, "phpmyadmin");

            // PHP
            phpPath = Path.Combine(appPath, "php");
            phpConfigPath = Path.Combine(phpPath, "php.ini");

            // MySQL
            mysqlPath = Path.Combine(appPath, "mysql");
            mysqlConfigPath = Path.Combine(mysqlPath, "my.ini");

            // Filezilla
            filezillaPath = Path.Combine(appPath, "FileZillaFTP");


            //--------- Check Services ------------
            if (!Directory.Exists(htdocsPath))
            {
                Directory.CreateDirectory(htdocsPath);
            }

            if (!Directory.Exists(apachePath))
            {
                MessageBox.Show("Apache does not exists"); return;
            }

            if (File.Exists(mysqlPath))
            {
                MessageBox.Show("MySQL does not exists"); return;
            }

            if (!Directory.Exists(phpPath))
            {
                MessageBox.Show("PHP does not exists"); return;
            }

            if (!Directory.Exists(phpMyAdminPath))
            {
                MessageBox.Show("phpMyAdmin does not exists"); return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AppendLog("program", "Initializing Control Panel");
            AppendLog("program", "Control Panel is ready to use.");
        }

        private void AppendLog(string appName,string log)
        {
            string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            textBox1.Text += $"{now}   [{appName}]   {log}\r\n";
        }

        private void start_stop_apache_Click(object sender, EventArgs e)
        {
            if(start_stop_apache.Text == "Start")
            {
                AppendLog("Apache", "Starting Apache server...");
                start_stop_apache.Text = "Stop";
                try
                {
                    var result = apacheService.StartApache(apachePath);
                    apache_pid_label.Text = result.pid.ToString();
                    apache_port_label.Text = result.port.ToString();
                    AppendLog("Apache", "Apache server started");
                }
                catch
                {
                    apache_pid_label.Text = "N/A";
                    apache_port_label.Text = "N/A";
                    AppendLog("Apache", "Apache server starting failed.");
                    start_stop_apache.Text = "Start";
                }
            }
            else
            {
                apacheService.StopApache();
                apache_pid_label.Text = "N/A";
                apache_port_label.Text = "N/A";
                start_stop_apache.Text = "Start";
            }
        }

        private void start_stop_mysql_Click(object sender, EventArgs e)
        {
            if (start_stop_mysql.Text == "Start")
            {
                AppendLog("MySQL", "Starting MySQL server...");
                start_stop_apache.Text = "Stop";
                try
                {
                    var result = mySQLService.Start(mysqlPath);
                    mysql_pid_label.Text = result.pid.ToString();
                    mysql_port_label.Text = result.port.ToString();
                    AppendLog("MySQL", "MySQL server started");
                }
                catch
                {
                    mysql_pid_label.Text = "N/A";
                    mysql_port_label.Text = "N/A";
                    AppendLog("MySQL", "MySQL server starting failed.");
                    start_stop_mysql.Text = "Start";
                }
                start_stop_mysql.Text = "Stop";
            }
            else
            {
                mySQLService.Stop();
                mysql_pid_label.Text = "N/A";
                mysql_port_label.Text = "N/A";
                start_stop_mysql.Text = "Start";
            }
        }

        private void filezilla_start_stop_btn_Click(object sender, EventArgs e)
        {
            if (filezilla_start_stop_btn.Text == "Start")
            {
                AppendLog("Filezilla", "Starting Filezilla server...");
                start_stop_apache.Text = "Stop";
                try
                {
                    var result = filezillaService.Start(filezillaPath);
                    filezilla_pid_label.Text = result.pid.ToString();
                    filezilla_port_label.Text = result.port.ToString();
                    AppendLog("Filezilla", "Filezilla server started");
                }catch{
                    filezilla_pid_label.Text = "N/A";
                    filezilla_port_label.Text = "N/A";
                    AppendLog("MySQL", "Filezilla server starting failed.");
                    filezilla_start_stop_btn.Text = "Start";
                }
                filezilla_start_stop_btn.Text = "Stop";
            }
            else
            {
                filezillaService.Stop();
                filezilla_pid_label.Text = "N/A";
                filezilla_port_label.Text = "N/A";
                filezilla_start_stop_btn.Text = "Start";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/k netstat -ano",
                UseShellExecute = true, // Must be true to open new window
                CreateNoWindow = false  // Show the window
            };

            Process.Start(psi);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = appPath,
                UseShellExecute = true // required to open folders
            };

            Process.Start(psi);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "services.msc",
                UseShellExecute = true // must be true to launch .msc files
            };

            Process.Start(psi);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }


            // Stop all services before exiting
            if (start_stop_apache.Text == "Stop")
            {
                apacheService.StopApache();
            }
            if (start_stop_mysql.Text == "Stop")
            {
                mySQLService.Stop();
            }
            if (filezilla_start_stop_btn.Text == "Stop")
            {
                filezillaService.Stop();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string url = "https://devamp.iiniit.com";

            var psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = apacheDevampConfPath,
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = mysqlConfigPath,
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = Path.Combine(filezillaPath, "FileZillaServer.xml"),
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://devamp.iiniit.com";

            var psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };

            Process.Start(psi);
        }
    }
}
