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
                isLeftBlocked = false;
                isRightBlocked = false;
                isTouchLeft = false;
                isTouchRight = false;
                isTouchWall = false;
                isTouchTop = false;
                isOnSlope = false;
                isOnMaxSlope = false;
                slopeAngle = 0f;
                errorAngle = 0f;
            }
        }

        [Header("Properties")]
        [SerializeField]
        private Vector2 charSize;
        [SerializeField]
        private Vector2 sensorSize;
        [SerializeField]
        private float widthOfSkin;
        [SerializeField]
        private int sensorCount;
        [SerializeField]
        private float minSensorLength;
        [SerializeField]
        private LayerMask physicInteract;

        [Header("Slope Properties")]
        [SerializeField]
        private float maxSlopeAngle;

        [Header("Physics Info")]
        public Collisions collisions;
        public Vector2 velocity;
        public Vector2 influenceVelocity;

        [SerializeField]
        private float gravity;
        [SerializeField]
        private float gravityDownMultiplier;
        [SerializeField]
        private float maxGravity;

        //Raycast holders
        private RaycastHit2D[] verticalCasts;
        private RaycastHit2D[] horizontalCasts;
        private RaycastHit2D hitSide;
        //--------------------------------

        private Transform body;
        private float offsetAngle;
        private float lengthCharSize;
        private float charSensorSize;

        private float lengthSensorSize;

        private Vector2 lastPosition;
        private Vector2 lastDirection;

        private Vector2 halfCharSize => charSize * 0.5f;
        private Vector2 halfCharSizeDir =>
            halfCharSize * ExtensionMethods.DegreesToVector2(0f-Mathf.Abs(collisions.slopeAngle))+
           halfCharSize * ExtensionMethods.DegreesToVector2(0f - Mathf.Abs(collisions.slopeAngle)+90f);

        private Vector2 halfSensorSize => sensorSize * 0.5f;

        public Vector2 CharSize => charSize;

        /// <summary>
        /// Initializing player size,sensor sizes,offset vaules, check if squeezes are possible
        /// </summary>
        /// <param name="body"></param>
        public void Init(Transform body)
        {
            this.body = body;
            offsetAngle = ExtensionMethods.Vector2ToDegrees(halfCharSize);
            lengthCharSize = halfCharSize.magnitude - widthOfSkin;
            lengthSensorSize = halfSensorSize.magnitude;

            horizontalCasts = new RaycastHit2D[sensorCount];
            verticalCasts = new RaycastHit2D[sensorCount];

            lastPosition = body.position;

            collisions.isInsidePlatform = false;
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

        public void OnGravityUpdate(PhysicsState state)
        {
            switch (state)
            {
                case PhysicsState.OnNormal:
                    UpdateGravityOnNormal();
                    break;
                case PhysicsState.OnWater:
                    UpdateGravityOnWater();
                    break;
            }
        }

        private void UpdateGravityOnNormal()
        {

        }

        private void UpdateGravityOnWater()
        { 
        
        }

        public void ForceMovePoint(Vector2 dirOfMovement)
        {
            body.position = body.position.ToVector2() + dirOfMovement;
        }

        public void GiveMomentumVelocity(Vector2 velocity)
        {
            influenceVelocity = velocity;
        }
    }
}