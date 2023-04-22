using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UserLife : MonoBehaviour
{
    private Animator am;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    private void Start()
    {
        am= GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if hit the trap
        if (collision.gameObject.CompareTag("trap"))
        {
            Die();
        }
    }

    private void Die()
    {
        am.SetTrigger("dead");
        //Make user not move once die
        rb.bodyType = RigidbodyType2D.Static;
    }

    //Reloading
    private void LevelRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
