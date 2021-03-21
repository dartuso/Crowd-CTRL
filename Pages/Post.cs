using System;
using System.ComponentModel.DataAnnotations;

namespace Crowd_CTRL.Pages
{

    public class Post
    {

        public Post()
        {
            ProfileUrl = "";
            Username = "";
            Embed = "";
            Text = "";
            Reaction = 0;
            PostedDate = DateTime.UnixEpoch;
        }

        public Post(string profileUrl, string username, string embed, string text, DateTime time)
        {
            ProfileUrl = profileUrl;
            Username = username;
            Embed = embed;
            Text = text;
            Reaction = 0;
            PostedDate = time;
        }

        public Post(string username, string text)
        {
            Username = username;
            Text = text;
            ProfileUrl = "Icons\\account.svg";
            Embed = "";
            Reaction = 0;
            PostedDate = DateTime.Now;
        }

        public Post(string text)
        {
            Username = "GhostCluster";
            Text = text;
            ProfileUrl = "Icons\\account.svg";
            Embed = "";
            Reaction = 0;
            PostedDate = DateTime.Now;
        }
        public Post(string username, string text, string embed)
        {
            Username = username;
            Text = text;
            ProfileUrl = "Icons\\account.svg";
            Embed = embed;
            Reaction = 0;
            PostedDate = DateTime.Now;
        }

        public DateTime PostedDate { get; set; }
        public string ProfileUrl { get; set; }
        public string Username { get; set; }
        public string Embed { get; set; }
        [Required]
        public string Text { get; set; }
        public uint Reaction { get; set; }
        
    }
}