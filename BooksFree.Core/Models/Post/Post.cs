using System;
using BooksFree.Core.Models.Common;

namespace BooksFree.Core.Models.Post {
    public class Post: BaseEntity {
        public User.User CreatedByUser { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Location Location { get; set; }
        public string Comment { get; set; }
        public Book.Book Book { get; set; }
        public PostStatus PostStatus { get; set; }
        public User.User AcceptedByUser { get; set; }
    }
}
