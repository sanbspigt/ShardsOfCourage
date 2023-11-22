//Dictionary is a key, value pair data structure which will store, retrive the data based on the key value
//private static Dictionary<string, int> highscores = new Dictionary<string, int>();
/*static void StoreData()
    {
        highscores["John"] = 10;
        UnityEngine.Debug.Log("Name of Player "+highscores["John"]);
    }*/

using System;
using System.Collections;
using System.Collections.Generic;

public static class ServiceLocator 
{  

    private static readonly Dictionary<Type, object> Services = new Dictionary<Type, object>();
       

    public static void Register<T>(object serviceInstance)
    {
        Services[typeof(T)] = serviceInstance;
    }

    public static void Register(object serviceInstance)
    {
        Services[serviceInstance.GetType()] = serviceInstance;
    }

    public static T LocateService<T>()
    {
        if (Services.ContainsKey(typeof(T)))
        {
            return (T)Services[typeof(T)];
        }
        return default(T);
    }

    public static bool Contains(Type t)
    {
        return Services.ContainsKey(t);
    }

    public static void Reset()
    {
        Services.Clear();
    }

}
