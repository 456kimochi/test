using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    private Vector3 pos;
    private bool goUp = false;
    public float speed = 1f;
    public float distance = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (goUp)
        {
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
            if (transform.position.y >= pos.y + distance)
            {
                goUp = false;
            }
        }
        else
        {
            transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
            if (transform.position.y <= pos.y - distance)
            {
                goUp = true;
            }
        }
    }
}
