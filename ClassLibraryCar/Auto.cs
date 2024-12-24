using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCar
{
    public class Auto
    {
        public string Title { get; set; }

        public string Number { get; set; }

        public Auto (string title, string nubmer) 
        {      
            Title = title;
            Number = nubmer;
        }

        public void Show() 
        { 
        
            Console.WriteLine($"Марака{Title} гос номер {Number}");
        }

    }
}
