using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ReplayScene : MonoBehaviour
{
    // Start is called before the first frame update
  public void ReplayGame()
  {
        SceneManager.LoadScene(0);
  }
    public void QuitGame()
    {
        Debug.Log("Exit Button Pressed");
        Application.Quit();
    }
}
