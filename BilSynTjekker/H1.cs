using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilSynTjekker;

internal class H1
{
    public string[] Teachers { get; set; }
    public string[] Students { get; set; }
    public string[] Courses { get; set; }


    public H1() 
    {
        Teachers = new string[] { "Niels Olesen", "Flemming Sørensen", "Peter Suni" };
        Students = new string[0];
        Courses = new string[0];
    }

}
