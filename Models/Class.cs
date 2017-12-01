﻿using System.Collections.Generic;

namespace ClassManagementSystem.Models
{
    public class Proportions
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int Report { get; set; }
        public int Presentation { get; set; }
    }

    public class Class
    {
        public Class(long id)
        {
            Id = id;
        }


        public long Id { get; }

        public int NumStudent => Students.Count;

        public List<User> Students { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

        public string Site { get; set; }

        public bool Calling { get; set; }

        public Proportions Proportions { get; set; }
    }
}