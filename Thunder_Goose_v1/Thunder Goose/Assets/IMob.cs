using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public interface IMob 
    {
        void Build(int level);

        string Attack();
        string Defend();

        //void RemoveStatusEffect(StatusEffect effect);
        //void AddStatusEffect(StatusEffect effect);

    }
}
