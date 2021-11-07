﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2.EF.Entities
{
    public class Author
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
