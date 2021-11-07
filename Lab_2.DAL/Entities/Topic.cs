using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2.DAL.Entities
{
    public class Topic
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
