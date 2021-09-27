using BugTrackerUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI.Services
{
    public class BugService : IBugService
    {
        private List<Bug> Bugs = new List<Bug>();

        public void AddBug(Bug newBug)
        {
            newBug.Id = Bugs.Count + 1;
            Bugs.Add(newBug);
        }

        public Bug GetBug(int id)
        {
            //return Bugs.FirstOrDefault(x => x.Id == id);
            return Bugs.Where(x => x.Id == id).First();
        }

        public IEnumerable<Bug> GetBugs()
        {
            return Bugs;
        }

        public void UpdateBug(Bug bug)
        {
            throw new NotImplementedException();
        }
    }

}
