using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Panel : MonoBehaviour
{
    [SerializeField] protected internal UnityEvent onTriggerEnter = new UnityEvent();
    
    private void OnTriggerEnter(Collider other)
    {
        onTriggerEnter.Invoke();
    }
}
