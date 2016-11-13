using UnityEngine;
using System.Collections;
using UnityEngine.UI;
/// <summary>
/// A class that displays the proximity sensor distance in ui text (Not Part Of the Observer Strategy)
/// </summary>
public class TrackedObject : MonoBehaviour {
    ProximitySensor proximitySensor;
    [SerializeField]
    Text uiText;
	// Use this for initialization
	void Start () {
        proximitySensor = GetComponent<ProximitySensor>();
        if (uiText == null)
            uiText = GetComponentInChildren<Text>();

    }
	
	// Update is called once per frame
	void Update () {
        if (proximitySensor.distance < 500)
            uiText.text = proximitySensor.distance.ToString("F1");

        //to get the closest target use:
        //proximitySensor.target
	}
}
