using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    sealed class Player :MonoBehaviour
    {
        private int level = 0;
        private string name = "Goosey Boi";
        private static readonly Player thePlayer;
        private GameObject playerObject;
        //private IWeapon weapon;
        //public static Player instance { get; set; }
        private Player()
        {
        }
        static Player()
        {
            Player player = new Player();
            Player.thePlayer = player;
        }
        public void PlayerMaker(int lvl, string pname)
        {
            this.level = lvl;
            this.name = pname;
        }

        public void MoveUp()
        {
            this.playerObject = playerObject = GameObject.FindWithTag("Player");
            Vector3 tempT = this.playerObject.transform.position;
            tempT.y += 1;
            Quaternion tempR = this.playerObject.transform.rotation;
            this.playerObject.transform.SetPositionAndRotation(tempT, tempR);
        }

        public void MoveDown()
        {
            this.playerObject = playerObject = GameObject.FindWithTag("Player");
            Vector3 tempT = this.playerObject.transform.position;
            tempT.y -= 1;
            Quaternion tempR = this.playerObject.transform.rotation;
            this.playerObject.transform.SetPositionAndRotation(tempT, tempR);
        }

        // Accessor methods
        public int Level
        {
            get { return this.level; }
            set { this.level = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public static Player ThePlayer
        {
            get
            {
                return Player.thePlayer;
            }
        }
        /*
        public IWeapon Weapon
        {
            get { return this.weapon; }
            set { this.weapon = value; }
        }
        */
    }
}
