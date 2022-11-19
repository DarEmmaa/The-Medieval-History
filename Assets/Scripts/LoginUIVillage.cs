using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoginUIVillage : MonoBehaviour
{

    [SerializeField] private TMP_InputField networthInputfield;


    [SerializeField] private Transform mainCameraTransform;
    [SerializeField] private Transform medeivalCityCenter;

    [SerializeField] private decimal networth;
    [SerializeField] private decimal minNetworth = 1M;
    [SerializeField] private decimal maxNetworth = 4.5M;

    [SerializeField] private TMP_Text outputText;



    private void Start()
    {

    }


    public void CheckVillageNetworth()
    {
        networth = decimal.Parse(networthInputfield.text);

        if (networth >= maxNetworth)
        {
            outputText.text = "Welcome to the Medieval Village";
            mainCameraTransform.position = medeivalCityCenter.position;
        }
        else
        {
            outputText.color = Color.white;
            outputText.text = "Sorry! Come back next time when you are eligible";
        }

    }
}
