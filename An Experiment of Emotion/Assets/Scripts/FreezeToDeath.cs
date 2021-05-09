using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FreezeToDeath : MonoBehaviour
{
    public float timeRemaining = 240;
    public Animator Shiver;
    public GameObject F1;
    public GameObject F2;
    public GameObject F3;
    public GameObject F4;
    public GameObject F5;
    public GameObject F6;
    public GameObject F7;
    public GameObject F8;
    public GameObject F9;
    public GameObject F10;
    public GameObject F11;
    public GameObject F12;
    public GameObject F13;
    public GameObject F14;
    public GameObject F15;
    public GameObject F16;
    public GameObject F17;
    public GameObject F18;
    public GameObject F19;
    public GameObject F20;
    public GameObject F21;
    public GameObject F22;
    public GameObject F23;
    public GameObject F24;
    public GameObject NormalLight;
    public GameObject FreezeLight;
    public GameObject Frozen1;
    public GameObject Frozen2;
    public GameObject Frozen3;
    public GameObject Frozen4;
    public GameObject Frozen5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining < 230)
        {
            F2.SetActive(true);
            F1.SetActive(false);
        }
        if (timeRemaining < 220)
        {
            F3.SetActive(true);
            F2.SetActive(false);
            Shiver.Play("Shiver 0");
        }
        if (timeRemaining < 210)
        {
            F4.SetActive(true);
            F3.SetActive(false);
            Frozen1.SetActive(true);
        }
        if (timeRemaining < 200)
        {
            F5.SetActive(true);
            F4.SetActive(false);
        }
        if (timeRemaining < 190)
        {
            F6.SetActive(true);
            F5.SetActive(false);
            NormalLight.SetActive(false);
            FreezeLight.SetActive(true);
        }
        if (timeRemaining < 180)
        {
            F7.SetActive(true);
            F6.SetActive(false);
            Frozen2.SetActive(true);
        }
        if (timeRemaining < 170)
        {
            F8.SetActive(true);
            F7.SetActive(false);
        }
        if (timeRemaining < 160)
        {
            F9.SetActive(true);
            F8.SetActive(false);
            Frozen3.SetActive(true);
        }
        if (timeRemaining < 150)
        {
            F10.SetActive(true);
            F9.SetActive(false);
        }
        if (timeRemaining < 140)
        {
            F11.SetActive(true);
            F10.SetActive(false);
            Frozen4.SetActive(true);
        }
        if (timeRemaining < 130)
        {
            F12.SetActive(true);
            F11.SetActive(false);
        }
        if (timeRemaining < 120)
        {
            F13.SetActive(true);
            F12.SetActive(false);
            Frozen5.SetActive(true);
        }
        if (timeRemaining < 110)
        {
            F14.SetActive(true);
            F13.SetActive(false);
        }
        if (timeRemaining < 100)
        {
            F15.SetActive(true);
            F14.SetActive(false);
        }
        if (timeRemaining < 90)
        {
            F16.SetActive(true);
            F15.SetActive(false);
        }
        if (timeRemaining < 80)
        {
            F17.SetActive(true);
            F16.SetActive(false);
        }
        if (timeRemaining < 70)
        {
            F18.SetActive(true);
            F17.SetActive(false);
        }
        if (timeRemaining < 60)
        {
            F19.SetActive(true);
            F18.SetActive(false);
        }
        if (timeRemaining < 50)
        {
            F20.SetActive(true);
            F19.SetActive(false);
        }
        if (timeRemaining < 40)
        {
            F21.SetActive(true);
            F20.SetActive(false);
            Shiver.Play("Stop");
        }
        if (timeRemaining < 30)
        {
            F22.SetActive(true);
            F21.SetActive(false);
        }
        if (timeRemaining < 20)
        {
            F23.SetActive(true);
            F22.SetActive(false);
        }
        if (timeRemaining < 10)
        {
            F24.SetActive(true);
            F23.SetActive(false);
        }
        if (timeRemaining < 0)
        {
            SceneManager.LoadScene("Sad");
        }

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }

        
    }
}
