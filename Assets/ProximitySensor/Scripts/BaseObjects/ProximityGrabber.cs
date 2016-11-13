using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
/// <summary>
/// A class that extends from Subject. It is responsible for adding observers (sensors) and updating their actions and targets
/// </summary>
public class ProximityGrabber : Subject {
    List<ProximitySensor> observerList;
    List<Transform> currentTargets;
    List<Transform> targets;

    public  ProximityGrabber() {
        observerList = new List<ProximitySensor>();
        
    }
    public void NotifyObserver() {
        currentTargets = new List<Transform>();

        for (int i = 0; i < targets.Count; i++) {
            if (targets[i].gameObject.activeInHierarchy)
                currentTargets.Add(targets[i]);
        }

        for (int i = 0; i < observerList.Count; i++) {
            currentTargets.Sort((a, b) => { return ( Vector3.Distance(a.position, observerList[i].myTransform.position) ).CompareTo(Vector3.Distance(b.position, observerList[i].myTransform.position)); });

            var target = ( currentTargets.Count > 0 ) ? currentTargets[0] : null;

            observerList[i].UpdateObserver(target);
        }
    }

    public void Register(ProximitySensor observer) {
        observerList.Add(observer);
    }

    public void Unregister(ProximitySensor observer) {
        observerList.Remove(observer);
    }
    public void UpdateTargets(List<Transform> targets) {
        this.targets = targets;
        NotifyObserver();
    }

 
}
