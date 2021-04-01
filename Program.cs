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

            await builder.Build().RunAsync();
        }

        public static User User = new User("TestUser");
        public static List<Friend> Friends = new()
        {
            new Friend("Friend1"),
            new Friend("Friend2"),
            new Friend("Friend3"),
            new Friend("Friend4"),
            new Friend("Friend5"),
        };

        public static readonly List<Post> Posts = new()
        {
            new("Icons\\account.svg", "Daniel", "Hey! Hope everyone is doing well!"),
            new("Icons\\account.svg", "Overwatch Gamer", "https://www.youtube-nocookie.com/embed/O161-WNZBP4", "Check out my overwatch game play."),
            new ("", "Your Clan “League Warriors” just joined the  “LCS Fall 2020” tournament!"),
            new ("", "Vector91831 is playing Overwatch! - Playing “Competitive” - 20m")
        };
    }
}
