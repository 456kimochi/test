using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScript : MonoBehaviour
{
    public Vector3 dir = new Vector3(0,0,0);
    public float speed = 10f;
    private Kirby player;
    private float distance = 0;

    private float standardDamage = 3;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Kirby>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dir == new Vector3(0, 0, 0))
        {
            Destroy(gameObject);
        }
        transform.position += dir.normalized * speed * Time.deltaTime;
        SetDistance();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Alien"))
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<Alien>().GetHit(standardDamage);
            player.energy += 8;
        }
        if (collision.gameObject.CompareTag("Boar"))
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<Boar>().GetHit(standardDamage);
            player.energy += 8;
        }
        if (collision.gameObject.CompareTag("Bat"))
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<Bat>().GetHit(standardDamage);
            player.energy += 8;
        }
        if (collision.gameObject.CompareTag("Spider"))
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<Spider>().GetHit(standardDamage);
            player.energy += 8;
        }
        if (collision.gameObject.CompareTag("Scopion"))
        {
            Destroy(gameObject);
            collision.gameObject.GetComponent<Scopion>().GetHit(standardDamage);
            player.energy += 8;
        }
        if (collision.gameObject.CompareTag("CrackedRock"))
        {
            Destroy(gameObject);
        }
    }

    private void SetDistance()
    {
        distance = transform.position.x - player.transform.position.x; 
        if (Mathf.Abs(distance) >= 7)
        {
            Destroy(gameObject);
        }

    }
}
