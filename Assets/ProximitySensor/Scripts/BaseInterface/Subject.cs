using UnityEngine;
using System.Collections;
/// <summary>
/// basic subject interface
/// </summary>
public interface Subject  {

    void Register(ProximitySensor observer);
    void Unregister(ProximitySensor observer);
    void NotifyObserver();
}
