using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleShield : MonoBehaviour
{
    public Animator anim;
    public GameObject shield;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Kirby>().poisonResist = true;
            anim.SetTrigger("Blown");
            Destroy(shield);
            Invoke("DestroyBubble", 0.35f);
        }
    }
    private void DestroyBubble()
    {
        Destroy(gameObject);
    }
}
