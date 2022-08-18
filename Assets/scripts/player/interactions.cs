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
    [SerializeField] private GameObject PlayerHUD;
    public move3d playerMovemntScript;
    // public move2D PlayerMove2D;
    // [SerializeField] private GameObject cmCam2d;
    [SerializeField] private GameObject endGoalHintCam;
    [SerializeField] private TextMeshProUGUI Pscore;     //Text variables grant us access to those objects' Text components
    private int Pcount;
    public int HP = 5;
    [SerializeField] private TextMeshProUGUI playerHP;


    private void Start()
    {
        Pscore.text = ("0");
    }

    private void Update()
    {
        Pscore.text = ("20/" + Pcount);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("win"))
        {
            PlayerHUD.SetActive(false);
            winCanvas.SetActive(true);
        }

        if (other.gameObject.CompareTag("powerUp"))
        {
            playerMovemntScript.jumpHeight ++;
            playerMovemntScript.Playerspeed++;
            Pcount++;
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

        if (other.gameObject.CompareTag("camChange"))
        {
            endGoalHintCam.SetActive(true);
            Invoke("disableEndGoalHint",4);
            Destroy(other.gameObject);
        }

        // if (other.gameObject.CompareTag("enemyview"))
        // {
        //     cmCam2d.SetActive(true);
        //     playerMovemntScript.enabled = false;
        //     PlayerMove2D.enabled = true;
        // }
    }

    void disableEndGoalHint()
    {
        endGoalHintCam.SetActive(false);
    }
}
