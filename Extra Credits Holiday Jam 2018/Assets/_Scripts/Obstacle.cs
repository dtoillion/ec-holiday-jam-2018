using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
  private float Speed = 7f;

  void FixedUpdate()
  {
    if(GameController.control.PresentCount >= 1)
      Speed = GameController.control.PresentCount + 7;
  }

	void Update () {
    transform.Translate(Vector3.right * -Speed * Time.deltaTime);
	}
}
