using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Crowd_CTRL.Pages
{
    public class ATeam
    {
        public ATeam() {
            teamNo = 0;
            teamName = "";
        }

        public ATeam(int num, string nam) {
            teamNo = num;
            teamName = nam;
        }
        public ATeam(int num) {
            teamNo = num;
            teamName = "";
        }

        public int teamNo {get; set; }
        
        [Required]
        public string teamName {get; set; }
    }
}