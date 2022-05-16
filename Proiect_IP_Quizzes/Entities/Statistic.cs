using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Statistic
    {
        public int UserId { get; private set; }
        public int TestsSubmitted { get; private set; }
        public int TestsPassed { get; private set; }
        public int TestsFailed { get; private set; }

        public Statistic(int userId, int testsSubmitted, int testsPassed, int testsFailed)
        {
            UserId = userId;
            TestsSubmitted = testsSubmitted;
            TestsPassed = testsPassed;
            TestsFailed = testsFailed;
        }
    }
}
