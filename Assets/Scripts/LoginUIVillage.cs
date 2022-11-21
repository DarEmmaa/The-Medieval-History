using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class LoginUIVillage : MonoBehaviour
{

    [SerializeField] private TMP_InputField networthInputfield;


    [SerializeField] private Transform mainCameraTransform;
    [SerializeField] private Transform medeivalVillageCenter;
    

    [SerializeField] private decimal networth;
    [SerializeField] private decimal maxNetworth = 4.5M;

    [SerializeField] private TMP_Text outputText;

  



    private void Start()
    {

    }


    public void CheckVillageNetworth()
    {
        networth = decimal.Parse(networthInputfield.text);

        if (networth > maxNetworth)
        {
            outputText.text = "Welcome to the Medieval Village";
            mainCameraTransform.transform.DOMove(medeivalVillageCenter.position, 5);//.onComplete(RotateCamera);
            mainCameraTransform.transform.DORotate(new Vector3(0.0f, -44.698f, 0.0f), 10.0f, RotateMode.Fast);
        }
        else
        {
            outputText.color = Color.white;
            outputText.text = "Sorry! Come back next time when you are eligible..." +
                "'Networth must be above 4.5'";
        }

    }

   

}
