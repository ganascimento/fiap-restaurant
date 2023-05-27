using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Infrastructure.Extensions
{
    public static class HostingEnviromentExtensions
    {
        private static readonly List<string> devEnviroment = new List<string>()
        {
            "development",
            "debug"
        };

        public static bool IsDevelopment(this IWebHostEnvironment env) {
            return devEnviroment.Contains(env.EnvironmentName.ToLowerInvariant());
        }

        public static bool IsTesting(this IWebHostEnvironment env)
        {
            return env.EnvironmentName.ToLowerInvariant() == "testing";
        }

    }
}
