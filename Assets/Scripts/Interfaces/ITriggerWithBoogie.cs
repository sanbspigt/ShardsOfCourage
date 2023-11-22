using ShardsOfCourage.Character;
using UnityEngine;

namespace ShardsOfCourage.Interface
{
    internal interface ITriggerWithBoogie
    {
        void OnTriggerEnter(PBoogieController pBoogie, Vector2 sourcePoint);
        void OnTriggerStay(PBoogieController pBoogie, Vector2 sourcePoint);
        void OnTriggerExit(PBoogieController pBoogie);
    }   
}

