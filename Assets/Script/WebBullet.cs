using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebBullet : MonoBehaviour
{
    public Vector3 dir;
    public float speed;
    private float damage = 0.5f;
    private Kirby player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Kirby>();
    }

    void Update()
    {
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            player.GetHit(damage);
            if (player.canDogde || player.dogding || player.followUpAttacking || player.tonadoing)
            {

            }
            else
            {
                if (player.webStatus == false)
                {
                    player.BeginWebStatus();
                }          
            }            
        }
    }
}
