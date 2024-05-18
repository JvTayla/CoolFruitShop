using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject infoPanel;

    public void StartGame()
    {
        SceneManager.LoadScene("UI Screens");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Info()
    {
        if (infoPanel != null)
        {
            infoPanel.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Info Panel not assigned in the Inspector.");
        }
    }

    public void Back()
    {
        if (infoPanel != null)
        {
            infoPanel.SetActive(false); // Deactivate the information panel
        }
        else
        {
            Debug.LogWarning("Info Panel not assigned in the Inspector.");
        }
    }
}
