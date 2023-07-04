using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lilb
{
    public class Room : IComparable<Room>
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public Room(string name, int area)
        {
            Name = name;
            Area = area;
        }
        public override string ToString()
        {
            string s = $"Данные о комнате:\n" +
                $"-название: {Name}\n" +
                $"-площадь: {Name} км. в кв.";
            return s;
        }
        public int CompareTo(Room other)
        {
            if (this.Area > other.Area) return 1;
            if (this.Area < other.Area) return -1;
            else return 0;
        }
        public void Show()
        {
            Console.WriteLine($"Комната: название = {Name}, площадь = {Area}");
        }
    }
}

