
using System;
using UnityEngine;

//Observado
public class BirdMovement : MonoBehaviour
{
    public float force;
    public float jumpSpeed;
    public bool IsRunning = true;

    private Animator mAnimator;
    private Rigidbody2D mRigidBody;

    private event EventHandler mGameOver;

    private void Start()
    {
        mAnimator = GetComponent<Animator>();
        mRigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (IsRunning && Input.GetMouseButtonDown(0))
        {
            /*mRigidBody.AddForce(new Vector2(
                0f,
                force
            ));*/
            mRigidBody.velocity = Vector3.up * jumpSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Se choco
        mRigidBody.velocity = Vector3.zero;
        mAnimator.SetTrigger("Die"); // Iniciamos el trigger
        mRigidBody.gravityScale = 0f;
        mGameOver?.Invoke(this, EventArgs.Empty);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Paso checkpoint");
    }

    public void AddGameOverDelegate(EventHandler handler)
    {
        mGameOver += handler;
    }
}
