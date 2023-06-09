using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Libreria que permite usar textmeshpro

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gemText;
    public int gems;






    private void Start()
    {
        RefreshUI();

    }

    public void RefreshUI()
    {
        gemText.text = "Gems: " + gems;

    }




}
