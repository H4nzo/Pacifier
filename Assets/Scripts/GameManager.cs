using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject TopContainer, BottomContainer, PlayContainer;

    private const string NEW_GAME = "NEW_GAME";
    private const string LOAD_GAME = "LOAD_GAME";

    public void Play()
    {
        TopContainer.SetActive(false);
        BottomContainer.SetActive(false);
        PlayContainer.SetActive(true);

    }

    public void Back()
    {
        TopContainer.SetActive(true);
        BottomContainer.SetActive(true);
        PlayContainer.SetActive(false);

    }

    public void NewGame()
    {
        SceneManager.LoadScene(NEW_GAME);
        PlayerPrefs.DeleteAll();
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(LOAD_GAME);
    }


}
