using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_pattern
{
    class CharacterFactory
    {
        private Dictionary<string, Character> characters = new Dictionary<string, Character>(); 

        public Character GetCharacter(string name, string type, string image)
        {
            string key = $"{name}-{type}"; 

            if (!characters.ContainsKey(key))
            {
                Character newCharacter = new Character(name, type, image);
                characters.Add(key, newCharacter);
                Console.WriteLine($"Создан новый персонаж: {newCharacter}");
                return newCharacter;
            }
            else
            {
                Console.WriteLine($"существующий персонаж: {characters[key]}");
                return characters[key];
            }
        }
    }
}
