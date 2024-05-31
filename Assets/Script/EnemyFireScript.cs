using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireScript : MonoBehaviour
{
    private GameObject alien;

    private void Start()
    {
        alien = GameObject.FindGameObjectWithTag("Alien");
    }
    public void EnemyFire()
    {
        alien.GetComponent<Alien>().speed = 0;
    }

    public void EnemyFireDone()
    {
        alien.GetComponent<Alien>().speed = 2;
    }

}
