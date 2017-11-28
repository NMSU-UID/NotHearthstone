using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public void PlayGameBTN(string playGame)
    {
        SceneManager.LoadScene(playGame);
    }

    public void ChooseDeckOneBTN(string deckOne)
    {
        SceneManager.LoadScene(deckOne);
    }

    public void ChooseDeckTwoBTN(string deckTwo)
    {
        SceneManager.LoadScene(deckTwo);
    }

    public void ExitGameBTN()
    {
        Application.Quit();
    }
}
