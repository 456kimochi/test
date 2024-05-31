using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger3 : MonoBehaviour
{
    public bool action;
    public GameObject heo1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (action)
            {
                heo1.GetComponent<Boar>().action = true;
            }
            else
            {
                heo1.GetComponent<Boar>().action = false;
            }
        }
    }
}
