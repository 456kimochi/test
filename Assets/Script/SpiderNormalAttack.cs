using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderNormalAttack : MonoBehaviour
{
    private Kirby player;
    private float damage = 1f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Kirby>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.GetHit(damage);
        }
    }
}
