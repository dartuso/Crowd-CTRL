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

        public static User User = new("TestUser");
        public static List<Friend> Friends = new()
        {
            new Friend("Gamer2123"),
            new Friend("Dinja"),
            new Friend("MickMercs"),
            new Friend("Pokemane"),
            new Friend("Keanu"),
        };

        public static readonly List<Post> Posts = new()
        {
            new("Avatars\\250px_cp2077_2.png","Daniel", "","Hey! Check out the new game: Raid Shadow Legends!"),
            new("Avatars\\250px_cp2077_1.png","cQx", "https://www.youtube-nocookie.com/embed/O161-WNZBP4", "Check out my overwatch game play!"),
            new ("GameIcon\\league.png","", "", "Your Clan “League Warriors” just joined the  “LCS Fall 2020” tournament!"),
            new ("GameIcon\\overwatch.png","", "", "Vector91831 is playing Overwatch! - Playing “Competitive” - 20m")
        };
    }
}
