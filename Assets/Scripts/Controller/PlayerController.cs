using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Moveable))]
public class PlayerController : MonoBehaviour
{
    public InputHandler inputHandler;
    private Moveable moveable;

    void Awake()
    {
        moveable = GetComponent<Moveable>();
    }

    void Update()
    {
        
    }

    private void OnSetDirection(Vector2 direction)
    {
        //Debug.Log("ABCD" + direction);
        moveable.setDirection(direction);
    }

    private void OnEnable()
    {
        inputHandler.OnSetDirectionAction += OnSetDirection;
    }

    private void OnDisable()
    {
        inputHandler.OnSetDirectionAction -= OnSetDirection;
    }
}

