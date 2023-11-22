using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceRegister : MonoBehaviour
{
    public MonoBehaviour service;

    private void Awake()
    {
        ServiceLocator.Register(service);
    }
}
