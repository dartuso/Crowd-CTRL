using System;
using System.ComponentModel.DataAnnotations;

namespace Crowd_CTRL.Comments
{
    public class Comment
    {
        public string Username;
        
        [Required]
        public string Text;
        
        public DateTime PostedDate;
    }
}