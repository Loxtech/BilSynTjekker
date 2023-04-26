using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilSynTjekker;

internal class H1 : IHovedForloeb
{
    public Person[] Teachers { get; set; }
    public string[] Students { get; set; }
    public string[] Courses { get; set; }
    public H1() 
    {
        Teachers = new Person[] 
        { 
          new Person(){FirstName = "Niels", LastName = "Olesen"},
          new Person(){FirstName = "Flemming", LastName = "Sørensen"},
          new Person(){FirstName = "Peter", LastName = "Suni"},
        };
        Students = new string[0];
        Courses = new string[0];
    }

    
}
