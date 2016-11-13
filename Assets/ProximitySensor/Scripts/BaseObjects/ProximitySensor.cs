using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
/// <summary>
/// a class that extends from observer and is the brain for the proximity sensor 
/// </summary>
public class ProximitySensor : MonoBehaviour, Observer {
    public float distance { get; private set; }
    public Transform myTransform { get; private set; }
    public Transform target { get; private set; }
    void Awake() {
        GrabSensors.currentGrabber.Register(this);
        myTransform = transform;
    }

    public void UpdateObserver(Transform target) {
        this.target = target;
        if (this.target == null) {
            distance = 1000;
            return;
        }
        float dir = Mathf.Sign(-Vector3.Dot(transform.forward, target.position - transform.position));
        
        distance = Vector3.Distance(transform.position, this.target.position) * dir;
    }
}
