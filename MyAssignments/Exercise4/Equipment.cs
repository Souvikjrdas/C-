using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public abstract class Equipment
    {
        public string name;
        public string description;
        public double dismovtilldate;
        public double mcost;
        public EquipType type;

        public virtual void MoveBy(double distance)
        {
            dismovtilldate = 0;
            mcost = 0;
        }
    }
}
