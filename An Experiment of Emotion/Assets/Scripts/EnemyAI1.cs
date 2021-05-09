using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject PlayerSpawn;
    Animator Anime;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.transform.position = PlayerSpawn.transform.position;
        }
    }
}
