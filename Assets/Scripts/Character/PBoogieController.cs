using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShardsOfCourage.Character
{
    public class PBoogieController : MonoBehaviour
    {
        public enum BoogieState
        {
            None,
            Preparing,
            Hidden,
            Normal,
            Dashing,
            GettingHit,
            HitSpike,
            Dead,
            Paused,
            MoveTo
        }

        public enum DamageType
        {
            Unknown,
            Obtacle,
            Enemy,
            Fall
        }

        [System.Serializable]
        public struct InputState
        {
            public Vector2 axis;
            public bool jumpPress;
            public bool jumpRelease;
            public bool dash;
            public bool attack;

            public void Reset()
            {
                jumpPress = false;
                jumpRelease = false;
                dash = false;
                attack = false;
            }
        }

        [System.Serializable]
        public struct BoogieMovementStatus
        {
            public bool dead;
            public bool vulnerable;
            public bool facingRight;
            public bool canMove;
            public bool canDash;
            public bool canDoubleJump;
            public bool isDashing;
            public bool isWallJumping;
            public bool isAttacking;
            public Vector2 moveInput;
        }

        [System.Serializable]
        public class BoogieProperties
        {
            public int health = 3;
            public bool fishMode;
            public void Reset()
            {
                health = 3;
                fishMode = false;
            }
        }

        public class BoogieAbility
        {
            public Ability doubleJump;
            public Ability wallJump;
            public Ability dash;
            public Ability dive;

            public BoogieAbility()
            {
                doubleJump = new Ability("Boogie.double-jump");
                wallJump = new Ability("Boogie.wall-jump");
                dash = new Ability("Boogie.dash");
                dive = new Ability("Boogie.dive");
            }

            public void Reset()
            {
                doubleJump.obtained = false;
                wallJump.obtained = false;
                dash.obtained = false;
                dive.obtained = false;
            }
        }

        [Header("Properties")]
        public float movingSpeed;
        public float gravity;
        public float maxVelovityDown;
        public float jumpForce;
        public float velDownMultiplier;
        public float groundMoveResponse;
        public float airMoveResponse;
        public float attackRate;
        public float attackBufferTime;
        public LayerMask attackLayer;
        public float coyoteTime;
        public float jumpBufferTime;
        public float wallJumpBuffer;
        [Header("Ability Properties")]
        public float dashForce;
        public float dashDuration;
        public BasePlayerPhysics physics;


    }
}