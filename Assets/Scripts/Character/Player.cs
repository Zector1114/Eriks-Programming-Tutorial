using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody physics;
    private Vector3 _moveDirection;
    private Vector3 _jumpDirection = Vector3.up;

    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
        InputManager.SetGameControls();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime * _moveDirection;
    }

    public void SetMovementDirection(Vector3 currentDirection)
    {
        _moveDirection = currentDirection;
    }

    public void JumpCheck(float currentJump)
    {
        if(currentJump > 0)
        {
            physics.AddForce(_jumpDirection * 10, ForceMode.Impulse);
        }
    }
}
