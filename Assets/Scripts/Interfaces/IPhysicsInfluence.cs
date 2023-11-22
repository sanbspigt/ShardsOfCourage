using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ShardsOfCourage.Interface
{
    internal interface IPhysicsInfluence
    {
        //Force the player to move in a specific direction
        void ForceMovePoint(Vector2 dirOfMovement);


        /// <summary>
        /// Calculate the momentum velocity.
        /// </summary>
        /// <param name="velocity"></param>
        void GiveMomentumVelocity(Vector2 velocity);
    }
}
