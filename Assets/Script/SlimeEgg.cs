using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEgg : MonoBehaviour
{
    public GameObject subLightHit;
    public GameObject subLightDestroy;
    public Transform subLightOrigin;
    public float HP;

    private void Start()
    {
        HP = 10;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Attack"))
        {
            HP -= 1;
            Instantiate(subLightHit, subLightOrigin.position, Quaternion.identity);
        }
    }
    private void Update()
    {
        if (HP <= 0)
        {
            Instantiate(subLightDestroy, subLightOrigin.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
