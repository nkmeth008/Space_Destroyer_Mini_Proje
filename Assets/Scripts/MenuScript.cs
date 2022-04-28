using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
   public void startButton()
   {

       SceneManager.LoadScene(1);

   }

    public void quitButton()
    {
        Application.Quit();

    }

    public void menuButton()
    {
        SceneManager.LoadScene(0);
    }

}

