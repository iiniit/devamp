using System;
using System.IO;
using System.Reflection;

namespace DevAMP
{
    internal class ResourceHelper
    {
        public static string GetEmbeddedResourceContent(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream($"DevAMP.{resourceName}"))
            {
                if (stream == null)
                {
                    throw new FileNotFoundException($"Resource '{resourceName}' not found.");
                }

                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
