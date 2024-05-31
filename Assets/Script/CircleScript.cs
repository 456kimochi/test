using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleScript : MonoBehaviour
{
    private Kirby player;
    private float standardDamage = 10;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Kirby>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Alien"))
        {
            collision.gameObject.GetComponent<Alien>().GetHit(standardDamage);
            player.energy += 15;
        }
        if (collision.gameObject.CompareTag("Boar"))
        {
            collision.gameObject.GetComponent<Boar>().GetHit(standardDamage);
            player.energy += 15;
        }
        if (collision.gameObject.CompareTag("Bat"))
        {
            collision.gameObject.GetComponent<Bat>().GetHit(standardDamage);
            player.energy += 15;
        }
        if (collision.gameObject.CompareTag("Spider"))
        {
            collision.gameObject.GetComponent<Spider>().GetHit(standardDamage);
            player.energy += 15;
        }
        if (collision.gameObject.CompareTag("Scopion"))
        {
            collision.gameObject.GetComponent<Scopion>().GetHit(standardDamage);
            player.energy += 15;
        }
    }
}
