using UnityEngine;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// Creates a subject 
/// allows for adding targets 
/// subscribes all the observers to the subject based on target distance 
/// (Singleton)  (Not Part Of the Observer Strategy)
/// </summary>
public class GrabSensors  {
    private static ProximityGrabber grabber;

    public static ProximityGrabber currentGrabber {
        get
        {
            if (grabber != null)
                return grabber;
            else {
                currentGrabber = new ProximityGrabber();
                return currentGrabber;
            }

        }
        set {
            if (grabber == null)
                grabber = value;
        }
    }

    static List<Transform> targets = new List<Transform>();

    public static void AddTracker(Transform target) {
        var t = targets.Find(e => e.transform == target);
        if (t == null) {
            targets.Add(target);
            currentGrabber.UpdateTargets(targets);
        }
    }

    public static void RemoveTracker(Transform target) {
        targets.Remove(target);
        currentGrabber.UpdateTargets(targets);
    }

    public static void NotifyObservers() {
        currentGrabber.NotifyObserver();
    }

}
