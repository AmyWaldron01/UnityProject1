using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class GhostBehaviour : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.0f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // account for different direction.
        if (transform.localScale.x > 0)
            rb.velocity = new Vector2(moveSpeed, 0f);
        else
            rb.velocity = new Vector2(-moveSpeed, 0f);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        // 2 colliders bounced off each other.
        // reverse the scale on the x value.
        // rb.velocity.x gives the horzontal movement.
        // get the sign of the current x vel and multiply by -1

        transform.localScale = new Vector2(-(transform.localScale.x), 2f);
    }

}
