using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour {

    //Card Variables 
    public Sprite cardArtWork;

    public int index;

    CardManager CM;

    public bool Open=false;

    void Awake()
    {
        //get the CardManager
        CM = FindObjectOfType<CardManager>();
    }

    //Get when pressing on the Card
    void OnMouseDown()
    {
        if (!Open)
        {
            //Send the Card to the Card Manager
            CM.CardSelected(this);
        }
    }

    //Card get Matched
    public void Chosen()
    {
        //Disable the Collider so we can no longer press on it
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    //The card get choosen after a wrong match
    public void OpenCard()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = cardArtWork;
        Open = true;
    }

    public void NoMatch()
    {
        Open = false;
    }

    //when you gat a wrong match
    public void NotChosen(Sprite FaceDown)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = FaceDown;
        Open = false;
    }
}
