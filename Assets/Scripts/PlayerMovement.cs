using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;

    private Vector2 currentVelocity;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {

        currentVelocity = rb.velocity;


        currentVelocity.x = Input.GetAxis("Horizontal") * moveSpeed;


        currentVelocity.y = Input.GetAxis("Vertical") * moveSpeed;
     


        rb.velocity = currentVelocity;

        FlipPlayer();
    }

    private void FlipPlayer()
    {
        if (currentVelocity.x < 0 && transform.right.x > 0)
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        else if (currentVelocity.x > 0 && transform.right.x < 0)
            transform.rotation = Quaternion.identity;
    }
}
