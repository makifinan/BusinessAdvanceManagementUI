using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Core
{
    public class AdvanceRequestHelper
    {
        public int NextStatuHelper(int workerRolID)
        {
            if (workerRolID == 1)
            {
                return 2;
            }
            if (workerRolID == 2)
            {
                return 4;
            }
            if (workerRolID == 3)
            {
                return 6;
            }
            if (workerRolID == 4)
            {
                return 8;
            }
            if (workerRolID == 5)
            {
                return 10;
            }
            return 0;
        }

        public int StatuFilterQueryHelper(int workerRolID)
        {
            if (workerRolID==2)
            {
                return 2;
            }
            if (workerRolID == 3)
            {
                return 4;
            }
            if (workerRolID == 4)
            {
                return 6;
            }
            if (workerRolID == 5)
            {
                return 8;
            }
            if (workerRolID == 6)
            {
                return 10;
            }
            if (workerRolID == 7)
            {
                return 12;
            }
            return 0;
        }
    }
}
