using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Slider slowMoSlider;
    public Toggle myToggle;

    public void PrintConsole()
    {
        Debug.Log("Apretar bot�n");
    }

    public void ChangeSlider()
    {
        PrintConsole();
    }

    private void Update()
    {
        Time.timeScale = slowMoSlider.value;
    }
}
