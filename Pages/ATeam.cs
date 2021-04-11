using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crowd_CTRL.Pages
{
    public class ATeam
    {
        public ATeam() {
            teamNo = 0;
            teamName = "";
            teamClick = "click" + teamNo;
        }

        public ATeam(int num, string nam) {
            teamNo = num;
            teamName = nam;
            teamClick = "click" + teamNo;
        }
        public ATeam(int num) {
            teamNo = num;
            teamName = "";
            teamClick = "click" + teamNo;
        }

        public int teamNo { get; set; }
        
        [Required]
        public string teamName { get; set; }

        public string teamClick { get; set; }
    }
}