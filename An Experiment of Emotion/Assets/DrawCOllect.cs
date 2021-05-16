using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrawCOllect : MonoBehaviour
{
    public int DrawingPresent;
    public GameObject Picture1;
    public GameObject Picture2;
    public GameObject Picture3;
    public GameObject Picture4;
    public GameObject Picture5;
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject Collectables = GameObject.Find("DrawingCollectItem");
            DrawingCollect drawingCollect = Collectables.GetComponent<DrawingCollect>();
            drawingCollect.DrawLeft = drawingCollect.DrawLeft - 1;
            this.gameObject.SetActive(false);
            DrawingPresent = DrawingPresent + 1;
            if (drawingCollect.DrawLeft == 0)
            {
                SceneManager.LoadScene("Frustration");
            }
            if (DrawingPresent == 1)
            {
                Picture1.SetActive(true);
            }
            if (DrawingPresent == 2)
            {
                Picture2.SetActive(true);
            }
            if (DrawingPresent == 3)
            {
                Picture3.SetActive(true);
            }
            if (DrawingPresent == 4)
            {
                Picture4.SetActive(true);
            }
            if (DrawingPresent == 5)
            {
                Picture5.SetActive(true);
            }
        }
    }
}
