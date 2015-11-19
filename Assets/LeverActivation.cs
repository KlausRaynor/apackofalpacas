﻿using UnityEngine;
using System.Collections;

public class LeverActivation : MonoBehaviour 
{
    public GameObject switchTarget;                 // what the switch object is connected to.
    public float rotationOffset = 45;
    public float positionOffset = .35f;

    private Vector3 activePosition;
    private Quaternion activeRotation;
    private bool isActivated;
    
    void Start() 
    {
        isActivated = false;
        activePosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + positionOffset);
        activeRotation = Quaternion.Euler(transform.rotation.x + rotationOffset, transform.rotation.y, transform.rotation.z);
    }
    
    void OnTriggerStay(Collider c)
    {
        if (c.tag == "Player") 
        {  
            if (Input.GetButton("Activate"))
            {
                isActivated = true;
                transform.position = activePosition;
                transform.rotation = activeRotation;
            }
        } 
    }
    
    public bool IsActivated()
    {
        return this.isActivated;
    }
}