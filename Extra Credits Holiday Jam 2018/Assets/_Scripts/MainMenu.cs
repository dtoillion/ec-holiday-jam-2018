using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class MainMenu : MonoBehaviour {

  public void StartGame() {
    SceneManager.LoadScene("Main");
  }

  void Update()
  {
    if(Input.GetKeyDown("space"))
    {
      // fade out music
      // fade out scene
      SceneManager.LoadScene("Main");
    }
  }

}
