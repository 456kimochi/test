using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger8 : MonoBehaviour
{
    public bool action;
    public GameObject bocap1;
    public GameObject bocap2;
    public GameObject nhen1;
    public GameObject nhen2;
    public GameObject nhen3;
    public GameObject tuongtrai;
    public GameObject tuongphai;

    private void Update()
    {
        if (bocap1.GetComponent<Scopion>().HP <=0 &&
            bocap2.GetComponent<Scopion>().HP <= 0 &&
            nhen1.GetComponent<Spider>().HP <= 0 &&
            nhen2.GetComponent<Spider>().HP <= 0 &&
            nhen3.GetComponent<Spider>().HP <= 0)
        {
            tuongtrai.SetActive(false);
            tuongphai.SetActive(false); 
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (action)
            {
                bocap1.GetComponent<Scopion>().action = true;
                bocap2.GetComponent<Scopion>().action = true;
                nhen1.GetComponent<Spider>().action = true;
                nhen2.GetComponent<Spider>().action = true;
                nhen3.GetComponent<Spider>().action = true;
                tuongtrai.SetActive(true);
                tuongphai.SetActive(true);
            }
            else
            {
                bocap1.GetComponent<Scopion>().action = false;
                bocap2.GetComponent<Scopion>().action = false;
                nhen1.GetComponent<Spider>().action = false;
                nhen2.GetComponent<Spider>().action = false;
                nhen3.GetComponent<Spider>().action = false;
            }
        }
    }
}
