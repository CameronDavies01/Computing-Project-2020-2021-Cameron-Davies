using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawingCollect : MonoBehaviour
{
    public float DrawLeft = 5.0f;
    public Text NumberOfDraw;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NumberOfDraw.text = DrawLeft.ToString() + " / 5";

        if (DrawLeft == 5)
        {

        }
    }
}
