using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class Zombie : Mob
    {
        public Zombie()
        {
            this.MobType = "Zombie";
            this.Health = 25;
            this.Level = 1;
            this.ArmorLevel = this.Level;
            this.ArmourHealth = 75;
            //this.mobObject = Instantiate(this.mobObject, Vector3.one, Quaternion.identity) as GameObject;
            //this.StatusEffects = new List<StatusEffect>();
        }
        public Zombie(int level)
        {
            this.MobType = "Zombie";
            this.Health = 3 * level;
            this.Level = level;
            this.ArmorLevel = this.Level;
            this.ArmourHealth = 6 * level;
            //this.StatusEffects = new List<StatusEffect>();
        }
        public Zombie(int level, GameObject mobject)
        {
            this.MobType = "Zombie";
            this.Health = 3 * level;
            this.Level = level;
            this.ArmorLevel = this.Level;
            this.ArmourHealth = 6 * level;
            this.mobObject = Instantiate(mobject, Vector3.one, Quaternion.identity) as GameObject;
        }
    }
}
