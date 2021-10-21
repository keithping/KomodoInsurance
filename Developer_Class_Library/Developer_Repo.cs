using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Class_Library
{
    //Here we give repo's CRUD methods
    class Developer_Repo
    {
        private readonly Dictionary<int, Developer> _developers;

        //This method adds a single developer to the dictionary.
        public bool AddDeveloper(Developer developer)
        {
            int count = _developers.Count();
            _developers.Add(developer.DeveloperID, developer);
            if (_developers.Count() == count + 1)
            {
                return true;
            }
            return false;
        }
      

        public Dictionary<int, Developer> GetDevelopers()
        {
            return _developers;
        }

        //Find a single developer using an ID.  We'll use the find method inside of the developer then remove them from the list.

        private Developer FindDeveloper(int developerID)
        {
            foreach(KeyValuePair<int, Developer> kvp in _developers)
            {
                if(kvp.Key == developerID)
                {
                    return kvp.Value;
                }
            }
            return null;
        }

        //This method removes a single developer from a dictionary by their ID.  (All I will get is an int [Dev ID]

        //Return the dictionary of developers

        public bool RemovedDeveloper(int developerID)
        {
            Developer returnedDeveloper = FindDeveloper(developerID);
            bool result =_developers.Remove(returnedDeveloper.DeveloperID);
            return result;

        }
        


        private void seedDeveloperData()
        {
            _developers.Add(01, new Developer { DeveloperName = "Shinji Ikari", DeveloperID = 01, HasPluralsightAccess = true });
            _developers.Add(02, new Developer {DeveloperName = "Rei Ayanami", DeveloperID = 02, HasPluralsightAccess =true });
            _developers.Add(03, new Developer {DeveloperName = "Asuka Langley", DeveloperID = 03, HasPluralsightAccess =true });
            _developers.Add(04, new Developer { DeveloperName = "Misato Katsuragi", DeveloperID = 04, HasPluralsightAccess = true });
            _developers.Add(05, new Developer { DeveloperName = "Gendo Ikari", DeveloperID = 05, HasPluralsightAccess = true });
            _developers.Add(06, new Developer { DeveloperName = "Ritsuko Akagi", DeveloperID = 06, HasPluralsightAccess = true });


    
        }
        
    }

}
