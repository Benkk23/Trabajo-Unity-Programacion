using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio; 

public class MainMenu : MonoBehaviour
{
    public GameObject menu, Object;

    public void StartGame()
    {
        print("Start Game");
        SceneManager.LoadScene("Juego");

    }

    public void Settings()
    {
       print("Settings");
       SceneManager.LoadScene("Settings");


    }

    public void Menu()
    {
        print("Back");
        SceneManager.LoadScene("");

    }

    public void Exit()
    {
       print("Exit");
        SceneManager.LoadScene("Menu");


    }


    public void ExitGame() => Application.Quit();








}

