using UnityEngine;
using ShardsOfCourage.Character;


namespace ShardsOfCourage.Interface
{
    internal interface ICollideWithBoogie
    {
        void OnCollisionEnter(PBoogieController pBoogie,Vector2 sourcePoint);
        void OnCollisionStay(PBoogieController pBoogie,Vector2 sourcePoint);
        void OnCollisionExit(PBoogieController pBoogie);
    }
}