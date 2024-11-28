using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowExplosion()
    {
        ObjectPool.GetInstance().RequestObject(PoolObjectType.EXPLOSION).activate(transform.position, Quaternion.identity);
    }
}

