using Developer_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Class_Library
{
    //Here we give POCO's properties.
    //Teams need to contain their Team members(Developers) and their Team Name, and Team ID.
    //Team members: string
    //Team name: string
    //Team ID: int
    public class DevTeam
    {
        public List<Developer> Team { get; set; } = new List<Developer>();
        //This needs to be a list
        public string DevTeamName { get; set; } 
        public int DevTeamID { get; set; }
    }
}
