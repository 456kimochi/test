using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    public bool action;
    public GameObject heo1;
    public GameObject doi1;
    public GameObject doi2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (action)
            {
                heo1.GetComponent<Boar>().action = true;
                doi1.GetComponent<Bat>().action = true;
                doi2.GetComponent<Bat>().action = true;
            }
            else
            {
                heo1.GetComponent<Boar>().action = false;
                doi1.GetComponent<Bat>().action = false;
                doi2.GetComponent<Bat>().action = false;
            }
        }
    }
}
