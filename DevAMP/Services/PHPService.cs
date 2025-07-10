using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevAMP.Services
{
    internal class PHPService
    {
        public void InitiatePHP(string phpPath, string phpConfigPath)
        {
            string phpConfigContent = ResourceHelper.GetEmbeddedResourceContent("Config.php.ini");
            phpConfigContent = phpConfigContent
                .Replace("{{PHP_PATH}}", phpPath);

            File.WriteAllText(phpConfigPath, phpConfigContent);
        }
    }
}
