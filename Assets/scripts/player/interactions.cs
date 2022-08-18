using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;     //to code the text & images ui
using TMPro;

public class interactions : MonoBehaviour
{
    [SerializeField]private GameObject winCanvas;
    public move3d playerMovemntScript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("win"))
        {
            winCanvas.SetActive(true);
        }

        if (other.gameObject.CompareTag("powerUp"))
        {
            playerMovemntScript.jumpHeight +=3;
            playerMovemntScript.Playerspeed++;
            Destroy(other.gameObject);
        }
    }
}
