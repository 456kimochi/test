using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger5 : MonoBehaviour
{
    public bool action;
    public GameObject doi1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (action)
            {
                doi1.GetComponent<Bat>().action = true;
            }
            else
            {
                doi1.GetComponent<Bat>().action = false;
            }
        }
    }
}
