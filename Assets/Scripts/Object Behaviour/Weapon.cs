using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float fireRate;
    private float timer = 0;
    public PoolObjectType type;

    void Start()
    {
        
    }

    void Update()
    {
        timer = timer - Time.deltaTime > 0 ? timer - Time.deltaTime : 0f;
    }

    public void Shoot()
    {
        if (timer == 0f)
        {
            ObjectPool.GetInstance().RequestObject(type).activate(transform.position, transform.rotation);
            timer = fireRate;
        }
    }
}
