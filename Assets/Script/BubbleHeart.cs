using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleHeart : MonoBehaviour
{
    public Animator anim;
    public GameObject heart;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Kirby>().HP = 10;
            anim.SetTrigger("Blown");
            Destroy(heart);
            Invoke("DestroyBubble", 0.35f);
        }
    }
    private void DestroyBubble()
    {
        Destroy(gameObject);
    }
}
