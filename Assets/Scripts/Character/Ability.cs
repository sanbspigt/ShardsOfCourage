using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShardsOfCourage.Character
{
    [System.Serializable]
    public class Ability 
    {
        public string id;
        public bool obtained;
        public Ability(string idName)
        {
            id = idName;
            obtained = false;
        }
    }
}