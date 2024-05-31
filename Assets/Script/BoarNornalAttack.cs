using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoarNornalAttack : MonoBehaviour
{
    private Kirby player;
    private float damage = 1;

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
