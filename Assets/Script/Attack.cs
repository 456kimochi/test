using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject splash;
    public Transform splashOrigin;
    private GameObject player;

    public GameObject tonado;
    public Transform tonadoOrigin;

    public GameObject atkrange;
    public GameObject followUp;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void SetRangeActive()
    {
        atkrange.SetActive(true);
    }
    public void SetRangeInactive()
    {
        atkrange.SetActive(false);
    }
    public void SplashCreate()
    {
        if (!player.GetComponent<Kirby>().splash) return;
        splash.GetComponent<SplashScript>().dir = player.GetComponent<Kirby>().direct;
        GameObject mySplash;
        if (player.GetComponent<Kirby>().direct == new Vector3(1, 0, 0))
        {
            mySplash = Instantiate(splash, splashOrigin.position, Quaternion.identity);
        }
        else
        {
            mySplash = Instantiate(splash, splashOrigin.position, Quaternion.FromToRotation(new Vector3(1, 0, 0), new Vector3(-1, 0, 0)));
        }
    }

    public void BeginFollowUp()
    {
        followUp.SetActive(true);
    }
    public void EndFollowUp()
    {
        followUp.SetActive(false);
    }

    public void BeginTonado()
    {
        tonado.GetComponent<WaterTonado>().dir = player.GetComponent<Kirby>().direct;
        GameObject myTonado;
        if (player.GetComponent<Kirby>().direct == new Vector3(1, 0, 0))
        {
            myTonado = Instantiate(tonado, splashOrigin.position, Quaternion.identity);
        }
        else
        {
            myTonado = Instantiate(tonado, splashOrigin.position, Quaternion.FromToRotation(new Vector3(1, 0, 0), new Vector3(-1, 0, 0)));
        }
    }
    public void BeginFollowUpAttacking()
    {
        player.GetComponent<Kirby>().followUpAttacking = true;
    }
    public void EndFollowUpAttacking()
    {
        player.GetComponent<Kirby>().followUpAttacking = false;
    }
}
