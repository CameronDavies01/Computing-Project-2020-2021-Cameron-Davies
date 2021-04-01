using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LightsOn : MonoBehaviour
{
    public Light LightOut;
    public Light LightOut2;
    public GameObject Hallway;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            LightOut.intensity = 1;
            LightOut2.intensity = 1;
            Hallway.SetActive(true);
        }
    }
}
