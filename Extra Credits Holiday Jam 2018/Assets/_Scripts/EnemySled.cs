using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySled : MonoBehaviour {

  public GameObject CrashedSled;
  private float Speed;
  private Rigidbody rb;

  void Start() {
    Speed = Random.Range(1, 2);
    rb = GetComponent<Rigidbody>();
    StartCoroutine(ActivatePhysics());
  }

  void Update()
  {
    transform.Translate(Vector3.right * Speed * Time.deltaTime);
  }

  IEnumerator ActivatePhysics() {
    yield return new WaitForSeconds(3);
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
