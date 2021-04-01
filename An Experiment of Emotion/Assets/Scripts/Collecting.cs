using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collecting : MonoBehaviour
{
    public float CoinsLeft = 100.0f;
    public Text NumberOfCoins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NumberOfCoins.text = CoinsLeft.ToString() + " / 100";

        if (CoinsLeft == 100)
        {

        }
    }
}
