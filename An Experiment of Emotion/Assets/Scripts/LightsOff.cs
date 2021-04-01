using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOff : MonoBehaviour
{

    public Light LightOut;
    public Light LightOut2;
    public Material Opened;
    public Object Self;
    public GameObject ERROR;
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
            LightOut.intensity = 0;
            LightOut2.intensity = 0;
            RenderSettings.skybox = Opened;
            Destroy(Self,1);
            ERROR.SetActive(true);
        }
    }
}
