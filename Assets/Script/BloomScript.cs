using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloomScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBloom", 4);
    }

    private void DestroyBloom()
    {
        Destroy(gameObject);
    }
}
