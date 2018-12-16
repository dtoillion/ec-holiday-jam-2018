using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

  public float PresentCount;
  public static GameController control;
  public Text PresentCountText;

  void Awake ()
  {
    if (control == null)
      control = this;
    else if (control != this)
      Destroy(gameObject);
  }

  public void PlayerCrashed() {
    Debug.Log("Player crashed");
    PresentCountText.text = ("You Crashed with " + PresentCount.ToString ("n0") + " Presents!!");
    StartCoroutine("PlayCrashedCR");
  }
  IEnumerator PlayCrashedCR()
  {
    yield return new WaitForSeconds(4);
    SceneManager.LoadScene("Main");
  }

}
