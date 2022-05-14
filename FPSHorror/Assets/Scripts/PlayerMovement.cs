#region

using UnityEngine;
using UnityEngine.InputSystem;

#endregion

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float gravity = -9.81f;
    public float speed = 3f;
    public float jumpHeight = 1f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private Vector3 _velocity;
    private bool _isGrounded;

    private void Update()
    {
        _isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (_isGrounded && _velocity.y < 0) _velocity.y = -2f;


        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        var movement = transform.right * x + transform.forward * y;

        controller.Move(movement * speed * Time.deltaTime);

        if (_isGrounded && Input.GetButtonDown("Jump")) _velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

        _velocity.y += gravity * Time.deltaTime;
        controller.Move(_velocity * Time.deltaTime);
    }
}