using System.Collections.Generic;


namespace Crowd_CTRL.Pages
{
    public class User
    {
        private const string DefaultProfile = "Icons\\account.svg";

        public string ProfilePicture { get; set; }
        public string Username { get; set; }
        public string Bio { get; set; }
        public List<string> Platforms { get; set; }
        public List<string> Games { get; set; }

        public User()
        {
            ProfilePicture = DefaultProfile;
            Username = "TestUsers";
            Bio = "";
            Platforms = new List<string>();
            Games = new List<string>();
        }

        public User(string username)
        {
            Username = username;
            ProfilePicture = DefaultProfile;
        }

        public User(string profilePicture, string username, string bio, List<string> platforms, List<string> games)
        {
            ProfilePicture = profilePicture ?? DefaultProfile;
            Username = username;
            Bio = bio;
            Platforms = platforms;
            Games = games;
        }
    }
}