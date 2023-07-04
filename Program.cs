using lilb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apartment ap = new Apartment("01", "Печушкин");
            ap.ShowAll();
            List<Room> room = new List<Room>();
            Console.WriteLine("работа со стандартным интерфейсом");
            Room rm1 = new Room("Прихожая", 10);
            room.Add(rm1);
            room.Add(new Room("Кухня", 15));
            room.Add(new Room("Спальня", 25));
            room.Sort();
            foreach (Room r in room)
            {
                r.Show();
            }
            {
                Console.ReadKey();
            }
        }
    }
}
