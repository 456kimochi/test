using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger9 : MonoBehaviour
{
    public bool action;
    public GameObject alien;
    public GameObject tuongtrai;

    private void Update()
    {
        if (alien.GetComponent<Alien>().HP <= 0)
        {
            tuongtrai.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (action)
            {
                alien.GetComponent<Alien>().action = true;
                tuongtrai.SetActive(true);
            }
            else
            {
                alien.GetComponent<Alien>().action = true;
            }
        }
    }
}
