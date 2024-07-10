using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class Patient
    {
        public Patient(TreatmentPlan plan)
        {
            this.plan = plan;
        }

        TreatmentPlan plan;
        public TreatmentPlan Plan { get { return plan; } }

        public void ToHeal()
        {
            switch (plan.TypePlan)
            {
                case 1:
                    Surgeon surgeon = new Surgeon();
                    surgeon.ToHeal();
                    break;
                case 2:
                    Dentist dentist = new Dentist();
                    dentist.ToHeal();
                    break;
                default:
                    Therapist therapist = new Therapist();
                    therapist.ToHeal();
                    break;
            }
        }
    }
}
