using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
