using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float speed;
    public Transform[] background;
    private Vector3 direction;

    void Start()
    {
        direction = new Vector3(0, -1, 0);
    }

    void Update()
    {
        PositionUpdate();
        checkPosition();
    }

    private void checkPosition()
    {
        if (background[0].position.y <= -41f)
            moveToTop(0);
        if (background[1].position.y <= -41f)
            moveToTop(1);
    }

    private void moveToTop(int index)
    {
        if (index == 0)
            background[0].position = background[1].position + new Vector3(0, 41, 0);
        else if (index == 1)
            background[1].position = background[0].position + new Vector3(0, 41, 0);

    }

    private void PositionUpdate()
    {
        background[0].position += direction * Time.deltaTime * speed;
        background[1].position += direction * Time.deltaTime * speed;
    }
}
