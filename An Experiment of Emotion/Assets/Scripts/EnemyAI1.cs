using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI1 : MonoBehaviour
{
    public float AnimationCheck1 = 50;
    public float AnimationCheck2 = 50;
    public GameObject Player;
    public GameObject Enemy;
    public GameObject PlayerSpawn;
    public GameObject EnemySpawn;
    Animator Anime;
    // Start is called before the first frame update
    void Start()
    {
        Anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookVector = Player.transform.position - transform.position;
        lookVector.y = transform.position.y;
        Quaternion rot = Quaternion.LookRotation(lookVector);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, 1);
        Enemy.transform.Translate(0, -0.1f, 0);

        if (AnimationCheck1 > 0)
        {
            AnimationCheck1 = AnimationCheck1 - 1;
        }

        if (AnimationCheck1 == 0)
        {
            Anime.gameObject.GetComponent<Animator>().enabled = false;
            if (AnimationCheck2 > 0)
            {
                AnimationCheck2 = AnimationCheck2 - 1;
            }
        }

        if (AnimationCheck2 == 0)
        {
            Anime.gameObject.GetComponent<Animator>().enabled = true;
            AnimationCheck1 = 50;
            AnimationCheck2 = 50;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.transform.position = PlayerSpawn.transform.position;
            Enemy.transform.position = EnemySpawn.transform.position;

        }
    }
}
