using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    private Animator myAnimator;
    private Rigidbody2D myRigidbody;
    private Vector2 movementFromInput;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        movementFromInput.x = Input.GetAxis("Horizontal");
        movementFromInput.y = Input.GetAxis("Vertical");
        myAnimator.SetFloat("X", movementFromInput.x);
        myAnimator.SetFloat("Y", movementFromInput.y);
        myAnimator.SetFloat("Velocity", movementFromInput.magnitude);
        myRigidbody.velocity = movementFromInput * movementSpeed;

    }
}
