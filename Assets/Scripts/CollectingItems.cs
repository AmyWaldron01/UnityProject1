using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectingItems : MonoBehaviour
{
    //counting melons
    private int melons = 0;

    [SerializeField] private Text melonText;


    //when colliding with the melon 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if players hit meon
        if(collision.gameObject.CompareTag("melon"))
        {
            Destroy(collision.gameObject);
            melons++;
            // Debug.Log("Melons: "+melons);
            melonText.text = "Melons: " +melons;
        }
    }
}
