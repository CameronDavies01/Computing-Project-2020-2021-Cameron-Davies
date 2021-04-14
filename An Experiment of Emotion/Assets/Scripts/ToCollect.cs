using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToCollect : MonoBehaviour
{
    public AudioSource Ding;
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
            GameObject Collectables = GameObject.Find("CollectSystem");
            Collecting collecting = Collectables.GetComponent<Collecting>();
            collecting.CoinsLeft = collecting.CoinsLeft - 1;
            Ding.Play();
            this.gameObject.SetActive(false);

            if (collecting.CoinsLeft == 0){
                SceneManager.LoadScene("Confusion 1");
            }
        }
    }

}
