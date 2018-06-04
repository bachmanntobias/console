using System;
using System.Collections.Generic;
using System.Text;

namespace Console
{
    class Table
    {
        public Table()
        {
            grades = new List<float>();

        }


        public void AddData(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades;

        public Statistics ComputeStatistics() 
        {
            Statistics stats = new Statistics();
            
            float sum = 0;

            foreach(float a in grades)
            {
                stats.Highest = Math.Max(a, stats.Highest);
                stats.Lowest = Math.Min(a, stats.Lowest);
                sum += a;
            }

            stats.Sum = sum;

            stats.Average = sum / grades.Count;



            return stats;
        }
    }
}
