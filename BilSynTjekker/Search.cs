using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilSynTjekker;

internal class Search
{
    public string SomeText { get; set; }
    private readonly H1 _h1;
    public Search(H1 h1, string someText)
    {
        _h1 = h1;
    }

    public List<Person> GetTeachers() 
    {
        Person? pMatched = _h1.Teachers.FirstOrDefault(a => a.FirstName == "Niels");
        List<Person> p = _h1.Teachers.ToList();
        p.Sort();
        return p;    
    }
}
