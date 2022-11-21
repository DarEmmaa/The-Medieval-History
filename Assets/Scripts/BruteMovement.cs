using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BruteMovement : MonoBehaviour
{
    [SerializeField] private GameObject brute;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   /* void OnCollisionEnter(Collision collision)
    {
        brute.transform.DORotate(new Vector3(0.0f, -90f, 0.0f), 10.0f, RotateMode.Fast);
        Debug.Log("collided");
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Brute"))
        {
            brute.transform.DORotate(new Vector3(0.0f, -90f, 0.0f), 10.0f, RotateMode.Fast);
            Debug.Log("collided");


        }
    }
}

