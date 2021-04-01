using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject Pistol;
    public GameObject Shotgun;
    public Rigidbody Bullet;
    private int BulletsLeft = 10;
    [SerializeField] private Transform BulletSpawn;
    Animator Anime;
    // Start is called before the first frame update
    void Start()
    {
        Anime = GetComponent <Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            print("R DOWN");
            Anime.Play("PistolReload 0");
            Anime.Play("ShotgunReload");
            BulletsLeft = 15;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            if (BulletsLeft > 0)
            {
                Bullet.transform.position = BulletSpawn.transform.position;
                Bullet.velocity = transform.TransformDirection(new Vector3(0, 0, -100));
                BulletsLeft = BulletsLeft - 1;
            }
        }

        //Pistol
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Pistol.SetActive(true);
            Shotgun.SetActive(false);
        }
        //Shotgun
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Pistol.SetActive(false);
            Shotgun.SetActive(true);
        }
    }
}
