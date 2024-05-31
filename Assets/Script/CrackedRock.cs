using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackedRock : MonoBehaviour
{
    public GameObject subLight;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Attack"))
        {
            Vector3 location = gameObject.transform.position;
            location.y -= 1;
            GameObject myLight = Instantiate(subLight, location, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
