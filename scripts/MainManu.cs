using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour {

	public void PlayGame()
    {
        //opnar fyrsta build index-ið sem er leikurinn sjálfur þanning að þú getur spilað
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        //lokar leiknum.        
        Application.Quit();
    }
}
