using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public abstract class Mob : MonoBehaviour, IMob
    {
        public GameObject mobObject;
        private int health;
        private int level;
        private string mobType;
        public int armorLevel;
        // i forgot what was going here 
        //private List<StatusEffect> statusEffects;

        private bool alive = true;
        private bool paralyzed = false;
        //add mode
        public int healthLevel;
        // the violence stuff
        // private int fireDamage = 0;
        private int armourHealth;
        //  private int roundsParalyzed = 0;
        private int damageReceived = 0;

        public void Build(int level)
        {
            this.Level = level;
            this.Health = this.Level * this.HealthLevel;
            this.ArmourHealth = this.Level * this.ArmorLevel;
            //this.StatusEffects = new List<StatusEffect>();
        }

        public string Attack()
        {
            return "Attacking: " + this.Level + " Damage Done!";

        }
        public string Defend()
        {
            return "Defending: " + this.Level + " Damage Blocked!";
        }

        public override string ToString()
        {
            return "Level " + this.Level + " " + this.MobType + " Health: " + this.Health;
        }

        public int Level
        {
            get { return this.level; }
            set { this.level = value; }
        }
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
        public string MobType
        {
            get { return this.mobType; }
            set { this.mobType = value; }
        }
        public int ArmorLevel
        {
            get { return this.armorLevel; }
            set { this.armorLevel = value; }
        }
        public int HealthLevel
        {
            get { return this.healthLevel; }
            set { this.healthLevel = value; }
        }
        public bool Paralyzed
        {
            get { return this.paralyzed; }
            set { this.paralyzed = value; }
        }
        public bool Alive
        {
            get
            {
                if (this.health < 1)
                {
                    return false;
                }
                else { return this.alive; }
            }
            set { this.alive = value; }
        }
        /*
        public int FireDamage
        {
            get { return this.fireDamage; }
            set { this.fireDamage = value; }
        }
        */
        public int ArmourHealth
        {
            get { return this.armourHealth; }
            set { this.armourHealth = value; }
        }/*
        public int RoundsParalyzed
        {
            get { return this.roundsParalyzed; }
            set { this.roundsParalyzed = value; }
        }
        

        //for now I just use the list 
        public List<StatusEffect> StatusEffects
        {
            get { return statusEffects; }
            set { this.statusEffects = value; }
        }


        public void RemoveStatusEffect(StatusEffect effect)
        {
            this.statusEffects.Remove(effect);
        }
        public void AddStatusEffect(StatusEffect effect)
        {
            this.StatusEffects.Add(effect);
        }
        */
        //might change this to a method?
        public int DamageReceived
        {
            set
            {
                if (this.armourHealth == 0)
                {
                    //double damage if no armor health left
                    this.Health -= value * 2;
                }
                else
                {
                    // the damage is reduced by the mob's armor level
                    this.Health -= (value * ((100 - armorLevel) / 100));
                }
                //now loop over all the status effects and use them, this can be improved
                /*
                foreach (StatusEffect effect in this.StatusEffects.ToList())
                {
                    effect.Use(this);
                }
                */
                //apply fire damage
                //this.Health -= this.FireDamage;
                //this.FireDamage = 0;

                //kill the mob if their health drops below 0:
                if (this.Health < 1)
                {
                    this.Alive = false;
                }
            }

        }
        public int ArmourDamageReceived
        {
            set
            {
                if (this.armourHealth > value)
                {
                    this.armourHealth -= value;
                }
                else
                {
                    this.armourHealth = 0;
                }

            }
        }

    }
}
