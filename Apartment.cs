using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lilb
{
    public class Apartment
    {
        public string Number { get; set; }
        public string Owner { get; set; }
        public List<Room> Rooms = new List<Room>();
        public Apartment(string number, string owner)
        {
            Number = number;
            Owner = owner;
        }
        public void ShowAll()
        {
            Console.WriteLine($"Квартира: номер = {Number}, владелец = {Owner}");
        }
    }
}
