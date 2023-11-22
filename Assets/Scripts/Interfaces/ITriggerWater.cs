using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShardsOfCourage.Interface
{
    internal interface ITriggerWater
    {
        void OnEnterWater(GameObject gObj,Vector2 force,bool clampForce = true);
        void OnStayWater(GameObject gObj);
        void OnExitWater(GameObject gObj, Vector2 force, bool clampForce = true);

        void SplahWater(GameObject gObj, Vector2 force, bool clampForce = true);
        
    }
}
