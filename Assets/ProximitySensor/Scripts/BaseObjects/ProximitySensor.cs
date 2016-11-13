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
        distance = Vector3.Distance(transform.position, this.target.position);
    }
}
