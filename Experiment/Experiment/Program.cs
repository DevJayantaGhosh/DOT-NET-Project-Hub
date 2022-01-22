using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Experiment
{
    //launchSettings.json has profile section -> ASPDOTNET_ENVIRONMENT that decide for appsetting.json & appsetting.{x}.json
    //If You Dont want to depents on launchSettings.json has profile section Want to depents on appsetting.json property
    public class Program
    {
        private static string env = "";
        public static void Main(string[] args)
        {


            SetYourEnv();
            CreateHostBuilder(args).Build().Run();
        }
      //Dont Depents on the launchSettins.json and ASPDOTNET_ENIRONMENT 
        public static void SetYourEnv()
        {
            try
            {
                var configBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json", false).Build();
                env = configBuilder.GetSection("MyENV").Value;
            }
            catch (Exception)
            {

                env="Jayanta";
            }
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)

            .ConfigureAppConfiguration((host, conf) =>
            {
                conf.AddJsonFile("appsettings.json");
                conf.AddJsonFile($"appsettings.{env}.json", true);
            })

            .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                 });
    }
}
