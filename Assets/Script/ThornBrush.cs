using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThornBrush : MonoBehaviour
{
    public float damage;

    private void Start()
    {
        damage = 0.2f;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Kirby>().HP -= damage;
        }
    }
}
