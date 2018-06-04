using System;
using System.Collections.Generic;
using System.Text;

namespace Console
{
    class Statistics
    {
        public Statistics()
        {
            Highest = 0;
            Lowest = float.MaxValue;
        }
        public float Average { get; set; }
        public float Sum { get; set; }

        public float Highest { get; set;  }
        public float Lowest { get; set; }
    }
}
