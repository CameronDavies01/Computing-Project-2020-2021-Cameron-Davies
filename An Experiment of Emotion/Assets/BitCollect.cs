using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BitCollect : MonoBehaviour
{
    public int BitPresent;

    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject CollectablesBit = GameObject.Find("BitCollectItem");
            BitCount bitCount = CollectablesBit.GetComponent<BitCount>();
            bitCount.BitLeft = bitCount.BitLeft - 1;
            this.gameObject.SetActive(false);
            BitPresent = BitPresent + 1;
            if (bitCount.BitLeft == 0)
            {
                SceneManager.LoadScene("Credits");
            }
        }
    }
}

