using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilSynTjekker;

internal class Search
{
    private readonly H1 _h1;
    public Search(H1 h1)
    { 
        _h1 = h1;
    }

    public string[] GetTeachers() 
    {
        return _h1.Teachers;    
    }
}
