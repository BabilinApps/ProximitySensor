using UnityEngine;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// basic observer interface with an addition to pass a list of transforms in the update function
/// </summary>
/// 
public interface Observer  {
    void UpdateObserver(Transform target);
}
