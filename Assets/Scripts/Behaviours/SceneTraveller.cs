using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneTraveller : MonoBehaviour
{
   public void LoadMap()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadBuilding()
    {
        SceneManager.LoadScene(0);

    }
}
