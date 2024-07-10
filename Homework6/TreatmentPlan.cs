using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class TreatmentPlan
    {
        public TreatmentPlan(int typePlan)
        {
            this.typePlan = typePlan;
        }

        int typePlan;
        public int TypePlan { get { return typePlan; } }
    }
}
