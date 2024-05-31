using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTonado : MonoBehaviour
{
    public Vector3 dir;
    public float speed = 7f;
    private float existTime = 5;
    private float damage = 25;
    private Kirby player;


    public GameObject subLight;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Kirby>();
        Invoke("DestroyTonado", existTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Alien"))
        {
            if (!collision.gameObject.GetComponent<Alien>().hitByTonado)
            {
                collision.gameObject.GetComponent<Alien>().GetHit(damage);
            }
            collision.gameObject.GetComponent<Alien>().hitByTonado = true;
        }
        if (collision.gameObject.CompareTag("Boar"))
        {
            collision.gameObject.GetComponent<Boar>().GetHit(damage);
        }
        if (collision.gameObject.CompareTag("Bat"))
        {
            collision.gameObject.GetComponent<Bat>().GetHit(damage);
        }
        if (collision.gameObject.CompareTag("Spider"))
        {
            collision.gameObject.GetComponent<Spider>().GetHit(damage);
        }
        if (collision.gameObject.CompareTag("Scopion"))
        {
            collision.gameObject.GetComponent<Scopion>().GetHit(damage);
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            speed = 0;
        }
    }

    private void DestroyTonado()
    {
        GameObject myLight = Instantiate(subLight, transform.position, Quaternion.identity);
        myLight.GetComponent<ParticleSystem>().startColor = Color.blue;
        Destroy(gameObject);
    }
}
