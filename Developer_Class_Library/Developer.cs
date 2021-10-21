using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Class_Library
{
    //Here we give POCO's properties.
    //Developers have names and ID numbers; we need to be able to identify one developer without mistaking them for another.
    //We also need to know whether or not they have access to the online learning tool: Pluralsight.
    //Pluralsight: bool
    //Developer name: string
    //Developer ID: int
    public class Developer
    {
        public string DeveloperName { get; set; }
        public int DeveloperID { get; set; }
        public bool HasPluralsightAccess { get; set; }
        
    }
}
