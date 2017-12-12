﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassManagementSystem.Models
{
    public class Seminar
    {
        public long Id { get; protected set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string GroupingMethod { get; set; }

        public List<Topic> Topics { get; set; }

        public Proportions Proportions { get; set; }
    }
}
