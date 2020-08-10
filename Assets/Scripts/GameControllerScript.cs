using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pipes;

    [SerializeField]
    private GameObject[] verticalPipes;

    [SerializeField]
    private GameObject winText;

    public int nextSceneLoad;

    bool isCoroutineStarted = false;

    public static bool win;

    void Start()
    {
        pipes = GameObject.FindGameObjectsWithTag("pipes");

        verticalPipes = GameObject.FindGameObjectsWithTag("verticalPipes");

        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;

        winText.SetActive(false);
        win = false;
    }
    
    void Update()
    {
        int count = 0;
        for (int i = 0; i < pipes.Length; i++)
        {
            if(pipes[i].transform.eulerAngles.z == 0)
            {
                count++;
            }
        }

        for (int i = 0; i < verticalPipes.Length; i++)
        {
            if (verticalPipes[i].transform.eulerAngles.z == 0 || verticalPipes[i].transform.eulerAngles.z == 180)
            {
                count++;
            }
        }

        //Debug.Log(count);
        if (count == (pipes.Length + verticalPipes.Length) && count != 0)
        {
            win = true;
            //Debug.Log(win);

            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }

            if (!isCoroutineStarted)
            {
                StartCoroutine(Wait());
            }
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        winText.SetActive(true);
        isCoroutineStarted = false;
    }
}
