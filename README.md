# ProximitySensor
A simple proximity sensor system created with the Observer Design Pattern 

To use the proximity sensor:
Add the ProximityTarget.cs to any object that you want to affect the sensors (see sample scene for example)
Add ProximitySensor.cs to any object that you want to be effected by the target

What�s inside the Proximity sensor:
Float distance; // distance to the target
Transform target; // closest target
