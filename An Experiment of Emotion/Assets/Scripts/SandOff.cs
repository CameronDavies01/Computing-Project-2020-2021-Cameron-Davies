using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandOff : MonoBehaviour
{
    public GameObject Sand;
    public GameObject Sand2;
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
            Sand.SetActive(false);
            Sand2.SetActive(true);
        }
    }
}
