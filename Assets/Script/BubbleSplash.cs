using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSplash : MonoBehaviour
{
    public Animator anim;
    public GameObject splash;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Kirby>().splash = true;
            anim.SetTrigger("Blown");
            Destroy(splash);
            Invoke("DestroyBubble", 0.35f);
        }
    }
    private void DestroyBubble()
    {
        Destroy(gameObject);
    }
}
