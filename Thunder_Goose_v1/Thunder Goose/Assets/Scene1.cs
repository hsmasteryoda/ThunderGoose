using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class Scene1 : MonoBehaviour
    {
        //this is going to act as program.cs or the main scene loop for this project
        // uses the monobehaviour methods
        Player player;
        MobFactory mobFactory;
        public GameObject mobtest;
        void Awake()
        {
            //make the player
            this.player = Player.ThePlayer;
            //make the mobfactory 
            this.mobFactory = new MobFactory();
            this.mobFactory.ZombieObject = mobtest;
            //load mobs based on difficulty
            this.mobFactory.PreLoadMobs(12);

            //for testing 
            this.mobFactory.SpawnZombie();
            this.mobFactory.SpawnZombie();
            this.mobFactory.SpawnZombie();
            this.mobFactory.SpawnZombie();
        }

        void Update() {
            
        }

    }
}
