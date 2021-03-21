using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Crowd_CTRL.Comments;

namespace Crowd_CTRL.Pages
{

    public class Post
    {
        private const int ReactionMax = 20;
        Func<uint> GenRandomReaction()
        {
            Random gen = new Random();

            return () => (uint) gen.Next(ReactionMax);
        }
        public Post()
        {
            ProfileUrl = "";
            Username = "";
            Embed = "";
            Text = "";
            Reaction = 0;
            PostedDate = DateTime.UnixEpoch;
            Comments = new List<Comment>();
            DisplayComments = false;
        }

        public Post(string profileUrl, string username, string embed, string text, DateTime time)
        {
            ProfileUrl = profileUrl;
            Username = username;
            Embed = embed;
            Text = text;
            Reaction = GenRandomReaction()();
            PostedDate = time;
            Comments = new List<Comment>();
            DisplayComments = false;
        }

        public Post(string username, string text)
        {
            Username = username;
            Text = text;
            ProfileUrl = "Icons\\account.svg";
            Embed = "";
            Reaction = 0;
            PostedDate = DateTime.Now;
            Comments = new List<Comment>();
            DisplayComments = false;
        }

        public Post(string text)
        {
            Username = "GhostCluster";
            Text = text;
            ProfileUrl = "Icons\\account.svg";
            Embed = "";
            Reaction = 0;
            PostedDate = DateTime.Now;
            Comments = new List<Comment>();
            DisplayComments = false;
        }
        public Post(string username, string text, string embed)
        {
            Username = username;
            Text = text;
            ProfileUrl = "Icons\\account.svg";
            Embed = embed;
            Reaction = 0;
            PostedDate = DateTime.Now;
            Comments = new List<Comment>();
            DisplayComments = false;
        }

        public DateTime PostedDate { get; set; }
        public string ProfileUrl { get; set; }
        public string Username { get; set; }
        public string Embed { get; set; }
        [Required]
        public string Text { get; set; }
        public uint Reaction { get; set; }
        
        public List<Comment> Comments { get; set; }

        public bool DisplayComments { get; set; }
    }
}