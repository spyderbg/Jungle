using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void OnLevel1Selected()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnLevel2Selected()
    {
        SceneManager.LoadScene("Level2");
    }
    
    public void OnLevel3Selected()
    {
        SceneManager.LoadScene("Level3");
    }
    
}
