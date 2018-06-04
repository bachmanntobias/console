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
                sum += a;
            }

            stats.sum = sum;

            return stats;
        }
    }
}
