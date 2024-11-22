using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class MoveRandom : MonoBehaviour
{
    private Moveable moveable;

    private void Awake()
    {
        moveable = GetComponent<Moveable>();
    }

    void Start()
    {
        moveable.setDirection(randomDirection(), randomDirection());
    }

    void Update()
    {
        
    }

    private float randomDirection()
    {
        return Random.Range(-1f, 1);
    }
}
