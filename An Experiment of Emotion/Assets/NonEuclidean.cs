using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonEuclidean : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerSpawn;
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
            Player.transform.Translate(20, 0, 0);
        }
    }
}
