using System;
using System.Collections.Generic;

namespace Crowd_CTRL.Pages
{
    public class Friend : User
    {
        private string Status { get; set; }

        public Friend(string username)
        {
            Status = RandomStatus() + RandomGame();
            Username = username;
            Bio = RandomBio();
            Games = RandomGames();
            Platforms = RandomPlatforms();
            ProfilePicture = RandomPicture();
        }
        public Friend()
        {
            Status = RandomStatus() + RandomGame();
            Username = RandomName();
            Bio = RandomBio();
            Games = RandomGames();
            Platforms = RandomPlatforms();
            ProfilePicture = RandomPicture();
        }

        
        
        private string RandomName()
        {
            return RandomStr(FriendData.Username)();
        }

        private string RandomBio()
        {
            return RandomStr(FriendData.Bio)() + RandomStr(FriendData.Games)();
        }

        private List<string> RandomGames()
        {
            List<string> randomGames = new List<string>();

            Random gen = new Random();
            for (int i = 0; i < gen.Next(5,20); i++)
            {
                randomGames.Add(RandomStr(FriendData.Games)());
            }

            return randomGames;
        }

        private List<string> RandomPlatforms()
        {
            List<string> randomPlatforms = new List<string>();

            Random gen = new Random();
            for (int i = 0; i < gen.Next(5,20); i++)
            {
                randomPlatforms.Add(RandomStr(FriendData.Platforms)() + ": " + Username);
            }

            return randomPlatforms;
        }

        private string RandomPicture()
        {
            return RandomStr(FriendData.Pictures)();
        }
        string RandomGame()
        {
            return RandomStr(FriendData.Games)();
        }
        
        string RandomStatus()
        {
            return RandomStr(FriendData.Statuses)();
        }
    
        static Func<string> RandomStr(List<string> list)
        {
            Random gen = new Random();
            return () => list[gen.Next(list.Count)];
        }


    }

    internal record FriendData
    {
        public static readonly List<string> Username = new()
        {
            "Daniel",
            "Teo",
            "Kevin",
            "Harrison"
        };
        
        public static readonly List<string> Bio = new()
        {
            "Most played: ",
            "Most achievements: ",
            "Favorite game: ",
        };

        public static readonly List<string> Statuses = new()
        {
            "Playing ",
            "Streaming ",
            "Online "
        };

        public static List<string> Games = new()
        {
            "League of Legends",
            "Overwatch",
            "Wii Sports",
            "Super Mario Bros.",
            "Mario Kart Wii",
            "PlayerUnknown's Battlegrounds",
            "Wii Sports Resort",
            "Pokemon Red / Green / Blue Version",
            "New Super Mario Bros.",
            "Tetris",
            "New Super Mario Bros. Wii",
            "Minecraft",
            "Duck Hunt",
            "Wii Play",
            "Kinect Adventures!",
            "Nintendogs",
            "Mario Kart DS"
        };

        public static List<string> Pictures = new()
        {
            "Icons//account.svg"
        };
        
        
        public static List<string> Platforms = new()
        {
            "Steam",
            "Battle.net",
            "GOG",
            "Epic",
            "Riot",
            "PSN",
            "Xbox",
        };
    }

}