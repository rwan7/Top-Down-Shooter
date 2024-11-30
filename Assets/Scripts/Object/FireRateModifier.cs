using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FireRateModifier : MonoBehaviour
{
    public float modifier = 0.2f;

    private List<Weapon> weapons;

    private void Awake()
    {
        weapons = GetComponentsInChildren<Weapon>().ToList<Weapon>();
    }

    void Start()
    {
        foreach (Weapon w in weapons)
        {
            w.AddFireRateModifier(modifier);
        }
    }

    private void OnDestroy()
    {
        foreach (Weapon w in weapons)
        {
            w.RemoveFireRateModifier(modifier);
        }
    }

    public void AddComponentToObject(GameObject go)
    {
        go.AddComponent<FireRateModifier>();
    }
}
