﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffortTests.Models
{
    public class Model
    {
        public Model()
        {
            IsActive = true;
        }

        public int Id { get; set; }

        public bool IsActive { get; set; }
    }
}
