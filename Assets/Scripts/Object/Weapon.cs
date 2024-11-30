using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float fireRate;
    public List<float> fireRateModifiers;
    private float timer = 0;
    public PoolObjectType type;

    void Start()
    {
        fireRateModifiers = new List<float>();
    }

    void Update()
    {
        timer = timer - Time.deltaTime > 0 ? timer - Time.deltaTime : 0f;
    }

    internal void AddFireRateModifier(float modifier)
    {
        fireRateModifiers.Add(modifier);
    }

    internal void RemoveFireRateModifier(float modifier)
    {
        fireRateModifiers.Remove(modifier);
    }

    public void Shoot()
    {
        if (timer == 0f)
        {
            ObjectPool.GetInstance().RequestObject(type).activate(transform.position, transform.rotation);
            timer = fireRate / GetFireRateModifier();
        }
    }

    private float GetFireRateModifier()
    {
        float mod = 1;

        foreach (float f in fireRateModifiers)
        {
            mod += f;
        }
        return mod;
    }
}
