using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{



    void Start()
    {
        


    }


    void Update()
    {
        



    }

    public void BttnPlay()
    {
        SceneManager.LoadScene("Scene1");
        print("Play");

    }

    public void BttnAbout()
    {

        print("About");

    }

    public void BttnQuit()
    {
        // print("Quit");

        Application.Quit();

    }
}
