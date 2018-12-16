using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

  public GameObject CrashedPresent;

  void OnCollisionEnter(Collision col)
  {
    if((col.gameObject.tag == "Player") || (col.gameObject.tag == "Obstacle"))
    {
      Destroy(gameObject);
      Instantiate(CrashedPresent, transform.position, transform.rotation);
    }
  }
}
