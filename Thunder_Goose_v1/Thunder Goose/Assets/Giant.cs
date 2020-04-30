using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class Giant : Mob
    {
        public Giant()
        {
            this.Level = 50;
            this.MobType = "Giant";
            this.HealthLevel = 10;
            this.ArmorLevel = 5;
            this.Build(this.Level);
        }
        public Giant(int level)
        {
            this.Level = level;
            this.MobType = "Giant";
            this.HealthLevel = 10;
            this.ArmorLevel = 5;
            this.Build(level);
        }
    }
}
