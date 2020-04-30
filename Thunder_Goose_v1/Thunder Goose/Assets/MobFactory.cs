using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class MobFactory
    {
        public GameObject ZombieObject;
        public GameObject WereWolfObject;
        public GameObject GiantObject;

        public Stack<Zombie> _zombiePool;
        public Stack<WereWolf> _wereWolfPool;
        public Stack<Giant> _giantPool;


        public MobFactory()
        {
            this._zombiePool = new Stack<Zombie>();
            this._wereWolfPool = new Stack<WereWolf>();
            this._giantPool = new Stack<Giant>();
        }
        public void PreLoadMobs(int SceneLevel)
        {
            //List<Mob> moblist = new List<Mob>();
            //creates 10 mobs, picks their types based on player and scene level
            System.Random rndm = new System.Random();

            foreach (int i in Enumerable.Range(1, SceneLevel * 10))
            {
                //random mob spawn level based on 5 levels below the player level, and 10 above their level
                int spawnLevel = rndm.Next(Math.Abs(Math.Min(Player.ThePlayer.Level, SceneLevel) - 10), Math.Max(Player.ThePlayer.Level, SceneLevel) + 20);

                if (spawnLevel < 25)
                {
                    this._zombiePool.Push(new Zombie(spawnLevel, this.ZombieObject));
                }
                else if (spawnLevel < 40)
                {
                    this._wereWolfPool.Push(new WereWolf(spawnLevel));
                }
                else if (spawnLevel >= 40)
                {
                    this._giantPool.Push(new Giant(spawnLevel));
                }
            }
        }

        public Zombie SpawnZombie()
        {
            if (this._zombiePool.Count > 0)
            {
                return this._zombiePool.Pop();
            }
            else
            {
                throw new Exception("Zombies pool depleted");
            }
        }
        public Mob SpawnWereWolf(string type, int level)
        {
            if (this._wereWolfPool.Count > 0)
            {
                return this._wereWolfPool.Pop();
            }
            else
            {
                throw new Exception("WereWolf pool depleted");
            }
        }
        public Mob SpawnGiant(string type, int level)
        {
            if (this._giantPool.Count > 0)
            {
                return this._giantPool.Pop();
            }
            else
            {
                throw new Exception("Giant pool depleted");
            }
        }

        public void ReclaimZombie(Zombie mob)
        {
            this._zombiePool.Push(mob);
        }
        public void ReclaimWereWolf(WereWolf mob)
        {
            this._wereWolfPool.Push(mob);
        }
        public void ReclaimGiant(Giant mob)
        {
            this._giantPool.Push(mob);
        }

        public Stack<Zombie> ZombiePool
        {
            get { return this._zombiePool; }
        }
        public Stack<Giant> GiantPool
        {
            get { return this._giantPool; }
        }
        public Stack<WereWolf> WereWolfPool
        {
            get { return this._wereWolfPool; }
        }


    }
}
