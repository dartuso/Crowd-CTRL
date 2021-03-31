using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Crowd_CTRL.Pages;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Crowd_CTRL
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSingleton<PageHistoryState>();
            
            await builder.Build().RunAsync();
        }

        public static string Username = "TestUser";
        static Func<DateTime> RandomDayFunc()
        {
            /*Credit: https://stackoverflow.com/questions/194863/random-date-in-c-sharp*/
            DateTime start = new DateTime(2021, 1, 1);
            Random gen = new Random();
            int range = (DateTime.Today - start).Days;
            return () => start.AddDays(gen.Next(range)).AddHours(gen.Next(24)).AddMinutes(gen.Next(60)).AddSeconds(gen.Next(60));
        }

        private static readonly Func<DateTime> GetRandomDate = RandomDayFunc();

        public static readonly List<Post> Posts = new List<Post>
        {
            new("Icons\\account.svg", "Daniel", "", "Hey! Hope everyone is doing well!", GetRandomDate()),
            new("Icons\\account.svg", "Overwatch Gamer", "https://www.youtube-nocookie.com/embed/O161-WNZBP4", "Check out my overwatch game play.", GetRandomDate()),
            new ("", "Your Clan “League Warriors” just joined the  “LCS Fall 2020” tournament!"),
            new ("", "Vector91831 is playing Overwatch! - Playing “Competitive” - 20m"),
        };
    }
}
