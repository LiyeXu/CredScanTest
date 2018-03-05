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
    string connstr2 = "server=tcp:eee.database.windows.net,1433;database=fff;Integrated Security=False;user=ggg@aaa;pwd=hhh;";
           string connstr3 = "server=tcp:aaa.database.windows.net,1433;database=credscandev;Integrated Security=False;user=credscansmoketestuser;pwd=credscansmoketestpwd;";		   
		   string connstr4 = @"{
  ""database_hostname"": ""tcp:aaa.database.windows.net"",
  ""database_username"": ""aaa"",
  ""database_password"": ""credscansmoketestpwd"",
  ""database_databasename"": ""DLWorkspaceJobs"",
}";
			string connstr5 = "jdbc:sqlserver://aaa.database.windows.net:1433;" +   
			"databaseName=aaa_bbb;user=theextradbuser;password=credscansmoketestpwd";
    }
}
