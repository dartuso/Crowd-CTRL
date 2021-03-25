using System.ComponentModel.DataAnnotations;

namespace Crowd_CTRL {
    public class Friend
    {
        public string Name { get; set; }

        public Friend(string fName){
            Name = fName;
        }
    }
}
