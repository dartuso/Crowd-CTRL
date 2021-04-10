using System.Collections.Generic;


namespace Crowd_CTRL.Pages
{
    public class User
    {
        private const string DefaultProfile = "Icons\\account.svg";

        public string ProfilePicture { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Bio { get; set; }
        public List<string> Platforms { get; set; }
        public List<string> Games { get; set; }
        

        public User()
        {
            ProfilePicture = DefaultProfile;
            Username = "";
            Password = "";
            Bio = "";
            Platforms = new List<string>();
            Games = new List<string>();
        }

        public User(string username)
        {
            ProfilePicture = DefaultProfile;
            Username = username;
            Password = "";
            Bio = "";
            Platforms = new List<string>();
            Games = new List<string>();
        }

        public User(string profilePicture, string username, string bio, List<string> platforms, List<string> games)
        {
            ProfilePicture = profilePicture;
            Username = username;
            Password = "";
            Bio = bio;
            Platforms = platforms;
            Games = games;
        }
    }
}