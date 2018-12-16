using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

  public float xRotation;
  public float yRotation;
  public float zRotation;

  void Update () {
    transform.Rotate(xRotation, yRotation, zRotation, Space.Self);
	}
}
