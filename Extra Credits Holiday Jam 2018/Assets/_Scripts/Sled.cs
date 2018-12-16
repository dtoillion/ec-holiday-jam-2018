using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sled : MonoBehaviour {

  public GameObject CrashedSled;
  public float Speed = 10f;
  private float MoveValueX;
  private float MoveValueY;
  private Rigidbody rb;

  private void Start () {
    rb = GetComponent<Rigidbody>();
  }

  private void Update () {
    MoveValueX = Input.GetAxis("Horizontal");
    MoveValueY = Input.GetAxis("Vertical");
  }

  private void FixedUpdate () {
    if((MoveValueY != 0) || (MoveValueX != 0))
    {
      MoveSled ();
    }
  }

  private void MoveSled()
  {
    rb.AddForce(transform.forward * -MoveValueY * Speed);
    rb.AddForce(transform.right * -MoveValueX * Speed);
  }

  void OnCollisionEnter(Collision col)
  {
    if(col.gameObject.tag == "PickUp")
    {
      GameController.control.PresentCount += 1f;
      GameController.control.PresentCountText.text = ("Presents: " + GameController.control.PresentCount.ToString ("n0"));

    }
    if(col.gameObject.tag == "Obstacle")
    {
      GameController.control.PlayerCrashed();
      Destroy(gameObject);
      Instantiate(CrashedSled, transform.position, transform.rotation);
    }
  }
}
