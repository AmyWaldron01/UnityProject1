using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToPlatfrom : MonoBehaviour
{
    // // This method is called when a 2D collider enters the trigger zone of the object this script is attached to
    // private void OnCollisionEnter2D(Collider2D collision)
    // {
    //     // Check if the object that entered the trigger zone is the "Player"
    //     if (collision.gameObject.name == "Player")
    //     {
    //         // Set the "Player" object's parent to this object
    //         collision.gameObject.transform.SetParent(transform);
    //     }
    // }

    // // This method is called when a 2D collider exits the trigger zone of the object this script is attached to
    // private void OnCollisionExit2D(Collider2D collision)
    // {
    //     // Check if the object that exited the trigger zone is the "Player"
    //     if (collision.gameObject.name == "Player")
    //     {
    //         // Set the "Player" object's parent to null, which detaches it from this object
    //         collision.gameObject.transform.SetParent(null);
    //     }
    // }

    // private void OnTriggerEnter2D(collider2D collision)
    // {
    //      // Check if the object that entered the trigger zone is the "Player"
    //     if (collision.gameObject.name == "Player")
    //     {
    //         // Set the "Player" object's parent to this object
    //         collision.gameObject.transform.SetParent(transform);
    //     }

    // }

    // private void OnTriggerExit2D(collider2D collision)
    // {
    //     // Check if the object that exited the trigger zone is the "Player"
    //     if (collision.gameObject.name == "Player")
    //     {
    //         // Set the "Player" object's parent to null, which detaches it from this object
    //         collision.gameObject.transform.SetParent(null);
    //     }

    // }


     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
