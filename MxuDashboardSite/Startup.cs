using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.IO;
using Hangfire;
using Hangfire.SqlServer;
using System.Collections.Generic;
using Hangfire.Dashboard;

namespace MxuDashboardSite
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseHangfireDashboard("/hangfire", new DashboardOptions
            {
                Authorization = new[] { new AuthorizationFilter() }
            }, new SqlServerStorage("HangfireConnectionString"));
        }
    }
}
