using System;
using System.Collections.Generic;
using System.Text;

namespace DrillWpfObject
{
    class Result
    {
        // write code here
        private string name_of_runner;
        private int distance_in_m;
        private double time;

        public Result(string name_of_runner, int distance_in_m, double time)
        {
            this.name_of_runner = name_of_runner;
            this.distance_in_m = distance_in_m;
            this.time = time;
        }

        public string Name_of_runner { get => name_of_runner; set => name_of_runner = value; }
        public int Distance_in_m { get => distance_in_m; set => distance_in_m = value; }
        public double Time { get => time; set => time = value; }

        public double MeterPerSecond()
        {
            return distance_in_m / time;
        }

        public override string ToString()
        {
            return "\n Name: " + Name_of_runner + "\n Distance(m): " + Distance_in_m + "\n Time(s): " + time + "\n M/s: " + MeterPerSecond();
        }
    }
}
