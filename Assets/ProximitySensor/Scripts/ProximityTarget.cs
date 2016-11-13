using UnityEngine;
using System.Collections;
/// <summary>
/// a class that registers the tracker to be calculated by the proximity observer   (Not Part Of the Observer Strategy)
/// This notifies the observers of the all the targets movements
/// </summary>
public class ProximityTarget : MonoBehaviour {
    // Use this for initialization
    void Awake() {
        
        GrabSensors.AddTracker(this.transform);
	}
	
	// Update is called once per frame
	void LateUpdate () {
        GrabSensors.NotifyObservers();
	}
}
