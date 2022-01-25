using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public abstract class EquipmentExtend
    {
        public string name;
        public string description;
        public double dismovtilldate;
        public double mcost;
        public EquipTypeExtend type;

        public virtual void MoveByExtend(double distance)
        {
            dismovtilldate = 0;
            mcost = 0;
        }
    }
}
