using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;

public class LoginUI : MonoBehaviour
{
    

    
    [SerializeField] private TMP_InputField networthInputfield;


    [SerializeField] private Transform mainCameraTransform;
    [SerializeField] private Transform medeivalCityCenter;
    [SerializeField] private Transform startMenuPosition;
   

    [SerializeField] private decimal networth;
    [SerializeField] private decimal minNetworth = 1M;
    [SerializeField] private decimal maxNetworth = 4.5M;

    [SerializeField] private TMP_Text outputText;



    private void Start()
    {
       
    }


    public void CheckNetworth()
    {
        networth = decimal.Parse(networthInputfield.text);

        if(networth >= minNetworth && networth <= maxNetworth)
        {
            outputText.text = "Welcome to the Medieval Village";
            mainCameraTransform.transform.DOMove(medeivalCityCenter.position, 5);//.onComplete(RotateCamera);
            mainCameraTransform.transform.DORotate(new Vector3(0.0f, -44.698f, 0.0f),10.0f, RotateMode.Fast)  ;
        }
        else
        {
            outputText.color = Color.white;
            outputText.text = "Sorry! Come back next time when you are eligible..." +
                "'Networth must be within 1 and 4.5'";
        }
        
    }

    /*public void RotateCamera()
    {
        mainCameraTransform.transform.DORotate(new Vector3(0.0f, -44.698f, 0.0f),2.0f, RotateMode.Fast)  ;
    }*/

    public void ReturnToMenu()
    {
        mainCameraTransform.transform.DOMove(startMenuPosition.position, 2);//.onComplete(RotateCamera);
        mainCameraTransform.transform.DORotate(new Vector3(0.0f, -94.785f, 0.0f), 5.0f, RotateMode.Fast);
    }



}
