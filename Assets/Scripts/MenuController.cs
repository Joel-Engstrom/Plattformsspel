using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject ButtonGroupMain;
    public GameObject ButtonGroupSelection;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SelectLevel()
    {
        ButtonGroupMain.SetActive(false);
        ButtonGroupSelection.SetActive(true);
    }

    public void MainMenu()
    {
        ButtonGroupMain.SetActive(true);
        ButtonGroupSelection.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
