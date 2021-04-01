using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrustrationTeleport : MonoBehaviour
{
    public GameObject Player;
    public GameObject Spawn;
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
            Player.transform.position = Spawn.transform.position;
        }
    }
}
