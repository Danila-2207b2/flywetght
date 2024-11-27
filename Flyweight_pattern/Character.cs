using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_pattern
{
    public class Character
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Image { get; private set; }
        public int Level { get; set; } 
        public int Experience { get; set; } 


        public Character(string name, string type, string image)
        {
            Name = name;
            Type = type;
            Image = image;
            Level = 1; 
            Experience = 0; 
        }

        public override string ToString()
        {
            return $"Name: {Name}, Type: {Type}, Image: {Image}, Level: {Level}, Experience: {Experience}";
        }
    }
}
