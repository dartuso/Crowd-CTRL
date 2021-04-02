using System;
using System.Collections.Generic;

namespace Crowd_CTRL.Pages
{
    public class ATournament
    {
        public ATournament() {
            TournamentName = "";
            GameName = "";
            NumberOfTeams = 2;          
            Rules = "";
            TeamNames = new List<ATeam>();
            Share = false;
            TDate = DateTime.Now.ToString();
        }

        // missing share information, checkbox value needed
        public ATournament(string TName, string GName, int noOfTeams, string GRules, List<ATeam> Teams, String aDate){
            TournamentName = TName;
            GameName = GName;
            NumberOfTeams = noOfTeams;
            Rules = GRules;
            TeamNames = Teams;
            TDate = aDate;
        }

        public string TournamentName {get; set; }
        public string GameName {get; set; }
        public int NumberOfTeams {get; set; }
        public string Rules {get; set; }
        public List<ATeam> TeamNames {get; set; }
        public bool Share {get; set; }

        public String TDate {get; set; }
    }
}