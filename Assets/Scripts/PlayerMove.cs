using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;
    private Vector2 moveValue;
    private float lookValue;
    private Rigidbody body;

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        body = GetComponent<Rigidbody>();
    }

    public void OnMove(InputValue value)
    {
        moveValue = value.Get<Vector2>() * moveSpeed;
    }

    public void OnLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x * rotationSpeed;
    }

    void Update()
    {
        body.AddRelativeForce(moveValue.x * Time.deltaTime, 0, moveValue.y * Time.deltaTime);
        body.AddRelativeTorque(0, lookValue * Time.deltaTime, 0);
    }
}
