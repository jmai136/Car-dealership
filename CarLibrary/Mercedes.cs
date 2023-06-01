﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Mercedes : Car<Mercedes>
    {
        public override int id { get; set; }
        public override int userId { get; set; }
        // Use .GetType().Name
        public override Mercedes make { get; }
        public override string model { get; set; }
        public override string color { get; set; }
        public override float age { get; set; }
        public override decimal price { get; set; }
        public override float miles { get; set; }
        public override string[] features { get; set; }
    }
}