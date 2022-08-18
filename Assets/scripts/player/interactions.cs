using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;     //to code the text & images ui
using TMPro;
using UnityEngine.SceneManagement;

public class interactions : MonoBehaviour
{
    [SerializeField]private GameObject winCanvas;
    public move3d playerMovemntScript;
    public move2D PlayerMove2D;
    [SerializeField] private GameObject cmCam2d;
    void Start()
    {
        // PlayerMove2D.enabled = false;
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
            playerMovemntScript.jumpHeight ++;
            playerMovemntScript.Playerspeed++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("SpecialPowerUp"))
        {
            playerMovemntScript.jumpHeight += 5;
            playerMovemntScript.Playerspeed++;
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("hazard"))
        {
            SceneManager.LoadScene(0);
        }

        // if (other.gameObject.CompareTag("enemyview"))
        // {
        //     cmCam2d.SetActive(true);
        //     playerMovemntScript.enabled = false;
        //     PlayerMove2D.enabled = true;
        // }
    }
}
