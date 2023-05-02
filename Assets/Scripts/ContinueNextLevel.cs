using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueNextLevel : MonoBehaviour
{
    [SerializeField] private string levelNameToLoad;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) NextLevel();
    }

    public void NextLevel()
    {
        if (levelNameToLoad != null)
        {
            SceneManager.LoadScene(levelNameToLoad);
        }
    }
}
