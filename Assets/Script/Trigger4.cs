using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger4 : MonoBehaviour
{
    public bool action;
    public GameObject bocap1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (action)
            {
                bocap1.GetComponent<Scopion>().action = true;
            }
            else
            {
                bocap1.GetComponent<Scopion>().action = false;
            }
        }
    }
}
