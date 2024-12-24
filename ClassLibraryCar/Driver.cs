using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibraryCar
{
    public class Driver 
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public List<Auto> Autos { get; set; } = new List<Auto>();

        public Driver(string name, string @class)
        {
            Name = name;
            Class = @class;
        }

        public void AddAuto(Auto auto)
        {
            Autos.Add(auto);
        }

        public void ShowAll()
        {
            Console.WriteLine($"Водитель: {Name}, Класс: {Class}");
            foreach (var auto in Autos)
            {
                auto.Show();
            }
        }
    }
}
