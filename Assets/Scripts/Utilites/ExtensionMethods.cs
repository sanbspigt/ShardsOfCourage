using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethods 
{
    public static Vector2 ToVector2(this Vector3 target)
    {
        return new Vector2(target.x,target.y);
    }

    public static Vector3 ToVector3(this Vector2 target)
    {
        return new Vector3(target.x, target.y,0f);
    }

    public static Vector2[] ToVector2Array(this Vector3[] source)
    {
        return Array.ConvertAll(source,ToVector2);
    }

    public static Vector3[] ToVector3Array(this Vector2[] source)
    {
        return Array.ConvertAll(source, ToVector3);
    }

    public static bool isNan(ref Vector2 value)
    {
        if (!float.IsNaN(value.x))
        {
            return float.IsNaN(value.y);
        }
        return true;
    }

    public static bool isNan(ref Vector3 value)
    {
        if (!float.IsNaN(value.x)&&!float.IsNaN(value.y))
        {
            return float.IsNaN(value.z);
        }
        return true;
    }

    public static void ChangeAxisX(this Transform trans, float x)
    {
        trans.position = new Vector3(x,trans.position.y,trans.position.z);
    }
    public static void ChangeAxisY(this Transform trans, float y)
    {
        trans.position = new Vector3( trans.position.x,y,trans.position.z);
    }
    public static void ChangeAxisZ(this Transform trans, float z)
    {
        trans.position = new Vector3( trans.position.x, trans.position.y,z);
    }

    public static Vector2 RadiansToVector2(float angleInR)
    {
        return new Vector2(Mathf.Cos(angleInR),Mathf.Sin(angleInR));
    }

    public static Vector2 DegreesToVector2(float angleInD)
    {
        return RadiansToVector2(angleInD * Mathf.Deg2Rad);
    }

    public static float Vector2ToDegrees(Vector2 dir)
    {
        dir.Normalize();
        return Mathf.Atan2(dir.y, dir.x)*Mathf.Rad2Deg;
    }
        
}
