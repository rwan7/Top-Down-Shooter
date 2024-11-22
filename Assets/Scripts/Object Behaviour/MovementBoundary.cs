using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class MovementBoundary : MonoBehaviour
{
    public Rect boundary;
    private Moveable moveable;

    private void Awake()
    {
        moveable = GetComponent<Moveable>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (isXOutOfBoundary())
        {
            moveable.setXDirection(0f);
        }
        if (isYOutOfBoundary())
        {
            moveable.setYDirection(0f);
        }
    }

    private bool isXOutOfBoundary()
    {
        return moveable.getNextPosition().x < boundary.xMin || moveable.getNextPosition().x > boundary.xMax;
    }

        private bool isYOutOfBoundary()
    {
        return moveable.getNextPosition().y < boundary.yMin || moveable.getNextPosition().y > boundary.yMax;
    }
}
