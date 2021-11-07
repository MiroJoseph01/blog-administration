using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2.EF.Entities
{
    public class Post
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public long AuthorId { get; set; }

        public Author Author { get; set; }

        public long TopicId { get; set; }

        public Topic Topic { get; set; }
    }
}
