using System.Collections.Generic;
using BooksFree.Core.Models.Common;

namespace BooksFree.Core.Models.Book {
    public class Book : BaseEntity {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int YearOfPublishing { get; set; }
        public List<Ganre> Ganres { get; set; }
        public List<string> ImagesPaths { get; set; }
        public string Description { get; set; }
    }
}
