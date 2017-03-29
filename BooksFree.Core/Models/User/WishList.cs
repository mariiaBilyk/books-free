using System.Collections.Generic;
using BooksFree.Core.Models.Book;
using BooksFree.Core.Models.Common;

namespace BooksFree.Core.Models.User {
    public class WishList: BaseEntity {
        public int UserId { get; set; }
        public List<Ganre> Ganres { get; set; }
        public List<string> Authors { get; set; }
        public List<BookShortInfo> Books { get; set; }    
    }
}
