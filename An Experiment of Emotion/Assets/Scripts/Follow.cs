using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Follow : MonoBehaviour
{
    public AudioSource JumpScare;
    [SerializeField] private Transform Target;
    [SerializeField] private Transform respawnPoint;

    [SerializeField] private Transform MonolithRespawn;

    public Transform Player;
    int MoveSpeed = 25;
    int MaxDist = 400;
    int MinDist = 300;

    void Update()
    {
        transform.LookAt(Player);
        if (Vector3.Distance(transform.position, Player.position) <= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {

            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        JumpScare.Play();
        SceneManager.LoadScene("Boredom");
        StartCoroutine(DelayAction(100));
        MonolithRespawn.transform.position = new Vector3(445, 20, 75);
    }
    IEnumerator DelayAction(float delayTime)
    {
        yield return new WaitForSeconds(100);
        MonolithRespawn.transform.position = new Vector3(445, 20, 75);
    }
}
