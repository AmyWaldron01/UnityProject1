using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMovement : MonoBehaviour
{
    //[SerializeField] private int scoreValue = 10;
    [SerializeField] float lifeTime = 5.0f;

    private Rigidbody2D rb;
    private float speed = 15.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(-1 * speed, 0);
        rb.velocity = Vector2.left * speed;
    }


}
