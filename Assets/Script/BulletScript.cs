using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Vector3 dir;
    public float speed = 2;
    private float damage = 1;
    private Kirby player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Kirby>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Ground"))
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
                if (player.poisonStatus == false)
                {
                    player.BeginPoisonStatus();
                }
            }
        }
    }
}
