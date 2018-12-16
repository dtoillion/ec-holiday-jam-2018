using UnityEngine;
using System.Collections;

public class DestroyOnTouch : MonoBehaviour {

  void OnTriggerEnter(Collider trig)
  {
    Destroy(trig.gameObject, 0);
  }

}
