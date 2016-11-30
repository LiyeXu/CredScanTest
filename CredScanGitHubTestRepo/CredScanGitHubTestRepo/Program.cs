using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CredScanGitHubTestRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bytes = System.IO.File.ReadAllBytes(@"[test_cert_path]");
            Console.WriteLine(Convert.ToBase64String(bytes));
        }
    }
}
