using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CredScanGitHubTestRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            var certPath = @"[cert_path]";
            var bytes = System.IO.File.ReadAllBytes(certPath);
            var b64str = Convert.ToBase64String(bytes);
            Console.WriteLine(b64str);
            var cert = new X509Certificate2(bytes);
            Console.WriteLine(cert.Thumbprint);
        }
    }
}
