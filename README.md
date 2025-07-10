# Devamp

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Windows](https://img.shields.io/badge/Platform-Windows-blue.svg)](https://www.microsoft.com/windows)
[![PHP](https://img.shields.io/badge/PHP-8.3+-777BB4.svg)](https://www.php.net/)
[![Apache](https://img.shields.io/badge/Apache-2.4+-D22128.svg)](https://httpd.apache.org/)
[![MySQL](https://img.shields.io/badge/MySQL-8.0+-4479A1.svg)](https://www.mysql.com/)

**Complete PHP development environment for Windows - A modern XAMPP alternative**

Devamp is an open-source PHP development stack that provides everything you need to build and test PHP applications locally on Windows. Pre-configured with Apache, PHP, MySQL, and FileZilla, it eliminates the complexity of setting up individual components.

## ✨ Features

- **🚀 One-Click Installation** - Complete setup in minutes
- **🔧 Pre-Configured Stack** - Apache, PHP 8.3+, MySQL 8.0, FileZilla
- **🎛️ Control Panel** - Manage all services from one interface
- **📊 phpMyAdmin** - Built-in database management
- **🔒 SSL Support** - HTTPS development with self-signed certificates
- **🌐 Virtual Hosts** - Multiple domain configuration
- **📝 Error Logging** - Comprehensive debugging information
- **⚡ Auto-Start Services** - Optional Windows service installation

## 🎯 What's Included

| Component | Version | Description |
|-----------|---------|-------------|
| **Apache** | 2.4.x | Web server with mod_rewrite, SSL support |
| **PHP** | 8.3.x | Latest PHP with essential extensions |
| **MySQL** | 8.0.x | Database server with optimized config |
| **FileZilla** | Latest | FTP server for file management |
| **phpMyAdmin** | Latest | Web-based MySQL administration |

## 📥 Download

Choose the version that matches your Windows system:

- **[Download 64-bit](https://devamp.iiniit.com/download)** (Recommended - Windows 10/11)
- **[Download 32-bit](https://devamp.iiniit.com/download)** (Legacy systems)

### System Requirements

- Windows 10 or Windows 11
- 2GB RAM minimum (4GB recommended)
- 1GB free disk space
- Administrator privileges

## 🚀 Quick Start

1. **Download** the installer for your system architecture
2. **Run as Administrator** and follow the installation wizard
3. **Launch** Devamp Control Panel from desktop shortcut
4. **Start** Apache and MySQL services
5. **Open** http://localhost in your browser

Your development environment is ready! 🎉

## 🛠️ Usage

### Creating Your First Project

1. Navigate to `C:\devamp\htdocs\`
2. Create a new folder for your project
3. Add your PHP files (start with `index.php`)
4. Access via `http://localhost/yourproject`

### Managing Databases

- Open **phpMyAdmin**: http://localhost/phpmyadmin
- Default credentials: `root` (no password)
- Create databases, tables, and manage data through the web interface

### Configuration Files

- **PHP Config**: `C:\devamp\php\php.ini`
- **Apache Config**: `C:\devamp\apache\conf\httpd.conf`
- **MySQL Config**: `C:\devamp\mysql\my.ini`

## 🤝 Contributing

We welcome contributions from developers of all skill levels! Here's how you can help:

- 🐛 **Report bugs** and suggest improvements
- 💡 **Submit feature requests** and ideas
- 🔧 **Fix issues** and add new features
- 📚 **Improve documentation** and write tutorials
- 🧪 **Test** on different Windows versions

See our [Contributing Guide](CONTRIBUTING.md) for detailed instructions.

## 🐛 Troubleshooting

### Common Issues

**Port 80 already in use?**
- Stop IIS or change Apache port in control panel

**MySQL won't start?**
- Check if another MySQL service is running
- Change MySQL port to 3307


## 📄 License

This project is licensed under the [MIT License](LICENSE.md) - see the license file for details.

---

**Made with ❤️ for the PHP community**

*Devamp - Making PHP development simple and accessible for everyone.*
