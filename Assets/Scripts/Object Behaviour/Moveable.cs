using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveable : MonoBehaviour
{
    public float speed;
    private Vector3 direction;

    void Start()
    {
        
    }

    void Update()
    {
       updatePosition(); 
    }

    private void updatePosition()
    {
        transform.position = getNextPosition();
    }

    public Vector3 getNextPosition()
    {
        return transform.position + (direction * Time.deltaTime * speed);
    }

    internal void setXDirection(float v)
    {
        direction.x = v;
    }

    internal void setYDirection(float v)
    {
        direction.y = v;
    }

    private void setDirection(Vector3 value)
    {
        direction = value;
    }

    public void setDirection(Vector2 value)
    {
        direction.x = value.x;
        direction.y = value.y;
    }
}
