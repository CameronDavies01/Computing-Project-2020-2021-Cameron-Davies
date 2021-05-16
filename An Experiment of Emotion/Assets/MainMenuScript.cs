using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public Button Button5;
    public Button Button6;
    public Button Button7;
    public Button Button8;
    public Button Button9;
    public Button Button10;

    public int Check;
    public GameObject Logo;

    // Start is called before the first frame update
    void Start()
    {
        Button1.onClick.AddListener(Level1);
        Button2.onClick.AddListener(Level2);
        Button3.onClick.AddListener(Level3);
        Button4.onClick.AddListener(Level4);
        Button5.onClick.AddListener(Level5);
        Button6.onClick.AddListener(Level6);
        Button7.onClick.AddListener(Level7);
        Button8.onClick.AddListener(Level8);
        Button9.onClick.AddListener(Level9);
        Button10.onClick.AddListener(Level10);
    }


    void Level1()
    {
        SceneManager.LoadScene("Freedom");
    }
    void Level2()
    {
        SceneManager.LoadScene("Apprehension");
    }
    void Level3()
    {
        SceneManager.LoadScene("Boredom");
    }
    void Level4()
    {
        SceneManager.LoadScene("Happy");
    }
    void Level5()
    {
        SceneManager.LoadScene("Hopelessness");
    }
    void Level6()
    {
        SceneManager.LoadScene("Sad");
    }
    void Level7()
    {
        SceneManager.LoadScene("Confusion 1");
    }
    void Level8()
    {
        SceneManager.LoadScene("Cozy");
    }
    void Level9()
    {
        SceneManager.LoadScene("Frustration");
    }
    void Level10()
    {
        SceneManager.LoadScene("Nostalgia");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Check == 0)
            {
                Logo.SetActive(true);
                Check = 1;
                Time.timeScale = 1;
            }
            else
            {
                Logo.SetActive(false);
                Check = 0;
                Time.timeScale = 0;
            }
        }
    }
    }
