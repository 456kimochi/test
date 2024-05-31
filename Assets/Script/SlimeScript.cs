using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeScript : MonoBehaviour
{
    public GameObject subLight;
    private Kirby player;
    private float damage = 3;
    
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Kirby>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Ground"))
        {
            Vector3 location = gameObject.transform.position;
            location.y += 1;
            GameObject myLight = Instantiate(subLight, location, Quaternion.identity);
            Destroy(gameObject);
            if (collision.gameObject.CompareTag("Player"))
            {
                player.GetHit(damage);
                if (player.canDogde || player.dogding || player.followUpAttacking || player.tonadoing)
                {

                }
                else
                {
                    if (player.poisonStatus == false)
                    {
                        player.BeginPoisonStatus();
                    }
                }
            }
        }  
    }
}
