using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySled : MonoBehaviour {

  public GameObject CrashedSled;
  private Rigidbody rb;

  void Start() {
    rb = GetComponent<Rigidbody>();
    StartCoroutine(ActivatePhysics());
  }

  IEnumerator ActivatePhysics() {
    yield return new WaitForSeconds (2);
    rb.isKinematic = false;
  }

  void OnCollisionEnter(Collision col)
  {
    if((col.gameObject.tag == "Player") || (col.gameObject.tag == "Obstacle"))
    {
      Instantiate(CrashedSled, transform.position, Quaternion.Euler(0, 180f, 0));
      Destroy(gameObject);
    }
  }
}
