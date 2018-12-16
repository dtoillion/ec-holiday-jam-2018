using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateObjects : MonoBehaviour {
  public bool PingPonger;
  public bool PointToPoint;
  public float Speed;
  public float WaitTime;

  private Vector3 PositionOne;
  private Vector3 PositionTwo;

  public float XOne;
  public float XTwo;

  public float YOne;
  public float YTwo;

  public float ZOne;
  public float ZTwo;

  void Start() {
    PositionOne = new Vector3(transform.position.x + XOne, transform.position.y + YOne, transform.position.z + ZOne);
    PositionTwo = new Vector3(transform.position.x + XTwo, transform.position.y + YTwo, transform.position.z + ZTwo);
  }

  void Update() {
    if(PointToPoint)
      transform.position = Vector3.Lerp (PositionOne, PositionTwo, (Time.time * Speed));
    if(PingPonger)
      transform.position = Vector3.Lerp (PositionOne, PositionTwo, Mathf.PingPong(Time.time * Speed, WaitTime));
  }

}
