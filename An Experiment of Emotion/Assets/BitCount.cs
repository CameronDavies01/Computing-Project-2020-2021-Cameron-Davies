using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BitCount : MonoBehaviour
{
    public float BitLeft = 10.0f;
    public Text NumberOfBit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NumberOfBit.text = BitLeft.ToString() + " / 10";

        if (BitLeft == 5)
        {

        }
    }
}
