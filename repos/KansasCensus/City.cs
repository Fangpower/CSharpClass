﻿/**@author Mikey Dowsett*/
namespace KansasCensus {
    class City {
        public string Name { get; set; }
        public int Population { get; set; }

        public City(string name, int population) { 
            Name = name;
            Population = population;
        }

        public override string ToString() {
            return $"{Name}, {Population:N0}";
        }
    }
}
