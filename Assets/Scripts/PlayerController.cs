using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float gravity = 9.8f;
    private float _fallVelocity = 0;

    public float inertionMax = 10;
    public float inertionSpeed = 10;
    public float RotationSpeed = 800;

    // Start is called before the first frame update
    private CharacterController _characterController;
    private Vector3 _moveVector;
    private float inertionReal;
    private bool Move;
    
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + RotationSpeed * Input.GetAxis("Mouse X") * Time.deltaTime, 0);
        
        _moveVector = Vector3.zero;
        
        if (Input.GetKey(KeyCode.W)) 
        {
            _moveVector += transform.forward;
            Move = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            _moveVector -= transform.right;
            Move = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            _moveVector -= transform.forward;
            Move = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _moveVector += transform.right;
            Move = true;
        }
        InertionSpeed();
        
    }

    void FixedUpdate()
    {
        _characterController.Move(_moveVector * inertionReal * Time.deltaTime);

        _fallVelocity += gravity * Time.fixedDeltaTime;
        _characterController.Move(Vector3.down * _fallVelocity * Time.fixedDeltaTime);

        if (_characterController.isGrounded)
        {
            _fallVelocity = 0;
        }
    }
    private void InertionSpeed()
    {
        
        if(inertionReal < inertionMax && Move == true)
        {
            inertionReal += Time.deltaTime * inertionSpeed;
            Move = false;
        }
        else
        {
            if (inertionReal > 0)
            {
                inertionReal -= Time.deltaTime * 30;
            }
            else
            {
                inertionReal = 0;
            }
        }
        
    }
}
