using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelsMenu : MonoBehaviour
{
    public void BackMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void loadLevel1()
    {
        SceneManager.LoadScene(2);
    }

    public void loadLevel2()
    {
        SceneManager.LoadScene(3);
    }

    public void loadLevel3()
    {
        SceneManager.LoadScene(4);
    }

    public void loadLevel4()
    {
        SceneManager.LoadScene(5);
    }

    public void loadLevel5()
    {
        SceneManager.LoadScene(6);
    }

    public void loadLevel6()
    {
        SceneManager.LoadScene(7);
    }

    public void loadLevel7()
    {
        SceneManager.LoadScene(8);
    }

    public void loadLevel8()
    {
        SceneManager.LoadScene(9);
    }

    public void loadLevel9()
    {
        SceneManager.LoadScene(10);
    }

    public void loadLevel10()
    {
        SceneManager.LoadScene(11);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
