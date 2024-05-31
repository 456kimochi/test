using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger6 : MonoBehaviour
{
    public bool action;
    public GameObject doi1;
    public GameObject heo1;
    public GameObject bocap1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (action)
            {
                doi1.GetComponent<Bat>().action = true;
                heo1.GetComponent<Boar>().action = true;
                bocap1.GetComponent<Scopion>().action = true;
            }
            else
            {
                doi1.GetComponent<Bat>().action = false;
                heo1.GetComponent<Boar>().action = false;
                bocap1.GetComponent<Scopion>().action = false;
            }
        }
    }
}
