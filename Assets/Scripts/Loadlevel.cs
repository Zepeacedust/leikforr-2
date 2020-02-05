using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadlevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadLevel(){
        //loada næsta level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
