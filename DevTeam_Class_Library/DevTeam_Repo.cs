using Developer_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeam_Class_Library
{
    //Here we give repo's CRUD methods
    class DevTeam_Repo
    {
        private readonly Dictionary<int, DevTeam> _devTeam = new Dictionary<int, DevTeam>();
       
       
        public bool AddDevToTeam(int devTeamID, Developer developer)
        {
            int teamCount = _devTeam.Count();
            DevTeam returnedDevTeam = FindDevTeam(devTeamID);
            returnedDevTeam.Team.Add(developer);
            if (_devTeam.Count() == teamCount + 1)
            {
                return true;
            }
            return false;
        }
        

        //This method adds a the developer team to the dictionary.
        public bool AddDevTeam(DevTeam devteam)
        {
            int teamCount = _devTeam.Count();
            _devTeam.Add(devteam.DevTeamID, devteam);
            if (_devTeam.Count() == teamCount + 1)
           {
                return true;
            }
           return false;
        }

        public Dictionary<int, DevTeam> GetDevTeams()
        {
            return _devTeam;
        }

        private DevTeam FindDevTeam(int devTeamID)
        {
            foreach (KeyValuePair<int, DevTeam> kvp in _devTeam)
            {
                if (kvp.Key == devTeamID)
                {
                    return kvp.Value;
                }
            }
            return null;

        }

        private void SeedDevTeamData()
        {
            _devTeam.Add(01, new DevTeam { DevTeamName = "Purple Team", DevTeamID = 01, });
            _devTeam.Add(02, new DevTeam { DevTeamName = "Orange Team", DevTeamID = 02, });
            _devTeam.Add(03, new DevTeam { DevTeamName = "Red Team", DevTeamID = 03, });
        }
    }
}

  

