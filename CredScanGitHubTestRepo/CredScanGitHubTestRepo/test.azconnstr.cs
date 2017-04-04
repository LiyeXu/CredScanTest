using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CredScanGitHubTestRepo
{

    class TestAzureSqlConnectionStringMonitoring
    {
        // This is a mockup sql azure connection string to be detected.
        string connstr = "Data Source=tcp:aaa.database.windows.net,1433;Initial Catalog=bbb;Integrated Security=False;User ID=ccc@aaa;Password=ddd;";
        string connstr2 = "server=tcp:aaa.database.windows.net,1433;database=bbb;Integrated Security=False;user=ccc@aaa;pwd=ddd;";
    }
}
