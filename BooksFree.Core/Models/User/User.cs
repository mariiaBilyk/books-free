using System.Collections.Generic;
using BooksFree.Core.Models.Common;

namespace BooksFree.Core.Models.User {
    public class User : BaseEntity {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImagePath { get; set; }
        public string Email { get; set; }
        public List<string> Phones { get; set; }
        public string AboutMe { get; set; }
        public List<string> LinksToSocialAcconts { get; set; }
        public Location Location { get; set; }  
    }
}
