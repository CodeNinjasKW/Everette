using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //game manager object
    [Header("Game Controller Object for controlling the game")]
    public GameController gameController;
    [Header("Default Velocity")]
    public float velocity = 5;
    //physics for the bird
    private Rigidbody2D rb;
    //height of the bird object on the y axis
    private float objectHeight;
    // Start is called before the first frame update
    void Start()
    {
        //game controller component
        gameController = GetComponent<GameController>();
        //speed for the game is at a playing state
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        //Object height equals the size of the height of the sprite
        objectHeight =
            transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;

    }

    // Update is called once per frame
    void Update()
    {
        //if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            //the bird will float up on the y axis and float back down on the y axis
            rb.velocity = Vector2.up * velocity;
        }

    }
}
