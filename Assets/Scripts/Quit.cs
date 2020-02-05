using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//takki til að hætta í leiknum á endanum
public class Quit : MonoBehaviour
{
    public void quit()
    {
        Application.Quit();
    }
    public void restart()
    {
        //loada næsta level
        SceneManager.LoadScene(0);
    }

}
