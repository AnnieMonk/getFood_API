using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using getFood_API.Database;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;

namespace getFood_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

        }
       
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
