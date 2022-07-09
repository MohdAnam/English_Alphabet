using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public void ResetCliked()
    {
        SceneManager.LoadScene("Alphabet");
    }
    public void BacktoMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void QuitApp()
    {
        Application.Quit();
    }

}
