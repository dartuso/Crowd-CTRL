﻿using System;
using System.Collections.Generic;

namespace Crowd_CTRL.Pages
{
    public class Friend : User
    {
        public string Status { get; set; }
        public bool isFriend { get; set; } = false;
        public bool isNotify { get; set; } = true;
        public Friend(string username, string profilePicture)
        {
            Status = RandomStatus() + RandomGame();
            Username = username;
            Bio = RandomBio();
            Games = RandomGames();
            Platforms = RandomPlatforms();
            ProfilePicture = profilePicture;
        }
        public Friend(string username, bool friend)
        {
            Username = username;
            isFriend = friend;
            Status = RandomStatus() + RandomGame();
            Bio = RandomBio();
            Games = RandomGames();
            Platforms = RandomPlatforms();
            ProfilePicture = RandomPicture();
        }
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
            var numbers = SeedHash(FriendData.Games.Count);

            foreach (var num in numbers)
            {
                randomGames.Add(FriendData.Games[num]);
            }
            
            return randomGames;
        }

        private List<string> RandomPlatforms()
        {
            List<string> randomPlatforms = new List<string>();

            var numbers = SeedHash(FriendData.Platforms.Count);

            foreach (var num in numbers)
            {
                randomPlatforms.Add(FriendData.Platforms[num]+ ": " + Username);
            }

            return randomPlatforms;
        }

        HashSet<int> SeedHash(int maxLength)
        {
            Random gen = new Random();
            HashSet<int> numbers = new HashSet<int>();
            while (numbers.Count < maxLength/3) {
                numbers.Add(gen.Next(maxLength));
            }

            return numbers;
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
            "Pokemon Red",
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
            // "Icons//account.svg",
            "Avatars//250px_cp2077_1.png",
            "Avatars//250px_cp2077_2.png",
            "Avatars//250px_cp2077_3.png",
            "Avatars//250px_cp2077_4.png",
            "Avatars//250px_cp2077_5.png",
            "Avatars//250px_cp2077_6.png",
            "Avatars//250px_cp2077_7.png",
            "Avatars//250px_cp2077_8.png",
            "Avatars//250px_cp2077_9.png",
            "Avatars//250px_cp2077_10.png",
            "Avatars//250px_cp2077_11.png",
            "Avatars//250px_cp2077_12.png",
            "Avatars//250px_cp2077_13.png",
            "Avatars//250px_cp2077_14.png",
            "Avatars//250px_cp2077_15.png",
            "Avatars//250px_cp2077_16.png",
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