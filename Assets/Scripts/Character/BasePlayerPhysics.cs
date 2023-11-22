using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ShardsOfCourage.Interface;

namespace ShardsOfCourage.Character
{
    public class BasePlayerPhysics : MonoBehaviour, IPhysicsInfluence
    {
        public enum PhysicsState {
            OnNormal,
            OnWater            
        }

        [System.Serializable]
        public struct Collisions
        {
            public bool isGrounded;
            public bool isGroundedPrev;
            public bool isLeftBlocked;
            public bool isRightBlocked;
            public bool isTouchLeft;
            public bool isTouchRight;
            public bool isTouchWall;
            public bool isTouchWallPrev;
            public bool isTouchTop;
            public bool isOnSlope;
            public bool isOnMaxSlope;
            public bool isInsidePlatform;
            public bool isInWater;
            public float slopeAngle;
            public float errorAngle;
            public float coyoteTime;
            public float jumpPressTime;
            public float groundedTime;

            public void Reset()
            {
                isGrounded = false;
            }
        }

        public void Init(Transform body)
        { 
            //Initializing player size,sensor sizes,offset vaules, check if squeezes are possible
        }

        public void PreUpdate()
        {
            //Pre Sensor Functionalities
            //Sersor Detection 
            //Sersor Validation 
        }

        public void OnUpdate()
        {
            //Post Sensor Functionalities
            //Coyote validation and sensor
            //Move
            //Late Sensor dectection and functions
        }

        public void Move()
        { 
            //Check the Sqeezing 
            //Find the Direction for movement 
            //Predict the fall angle and position 
        }

        bool CheckingSqeeze()
        {
            return false;
        }

        void VerticalSensor()
        { 
            //Check the collisions vertically 
        }

        void HorizontalSensor()
        {
            //Check the collisions vertically 
        }

        void EdgeSensor()
        { 
        
        }

        void GroundSensor()
        { 
        
        }
        void SlopeSensor()
        { 
        
        }
        void CoyoteSensor()
        { 
        
        }

        public void OnGravityUpdate()
        { 
        
        }

        public void ForceMovePoint(Vector2 dirOfMovement)
        {
            throw new System.NotImplementedException();
        }

        public void GiveMomentumVelocity(Vector2 velocity)
        {
            throw new System.NotImplementedException();
        }
    }
}