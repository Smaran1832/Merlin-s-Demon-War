using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
    using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
         #if UNITY_EDITOR
             EditorApplication.isPlaying = false;
         #else
            Application.Quit();
         #endif
    }
}
