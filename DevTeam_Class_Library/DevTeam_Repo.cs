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
        private readonly Dictionary<int, DevTeam> _devTeam;

        //This method adds a the developer team to the dictionary.
        public bool AddDevTeam(DevTeam devteam)
        {
            int teamCount = _devTeam.Count();
            if (_devTeam.Count() == teamCount + 1)
            {
                return true;
            }
            return false;
        }

        public Dictionary<int, DevTeam> GetDevTeam()
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

        private void seedDevTeamData()
        {
            _devTeam.Add(01, new DevTeam { DevTeamName = "Purple Team", DevTeamID = 01, HasPluralsightAccess = true });
            _developers.Add(02, new Developer { DeveloperName = "Rei Ayanami", DeveloperID = 02, HasPluralsightAccess = true });
            



        }
    }
}

  

