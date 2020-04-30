using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    public class WereWolf : Mob
    {
        public WereWolf()
        {
            this.MobType = "WereWolf";
            this.Health = 150;
            this.Level = 25;
            this.ArmorLevel = this.Level;
            this.ArmourHealth = 25;
            //this.StatusEffects = new List<StatusEffect>();
        }
        public WereWolf(int level)
        {
            this.MobType = "WereWolf";
            this.Health = level * 6;
            this.Level = level;
            this.ArmorLevel = this.Level;
            this.ArmourHealth = level;
            //this.StatusEffects = new List<StatusEffect>();
        }
    }
}
