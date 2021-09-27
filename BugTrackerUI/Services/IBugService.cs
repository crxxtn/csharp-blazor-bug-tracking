using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI
{
    public interface IBugService
    {
        Bug GetBug(int id);
        IEnumerable<Bug> GetBugs();
        void AddBug(Bug newBug);
        void UpdateBug(Bug bug);
    }
}

