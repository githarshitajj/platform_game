using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ctrl+k then ctrl+f we can reformat the document according to the set preferences 

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        //Debug.Log("Hello, World!");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2 (dirX * 7f, rb.velocity.y);


        //adding the movement for jumping in update so we can be able to jump at every frame of our game - guesses: gonna use the vector2 thingy?, keydown
        //and keyUp too?
        if (Input.GetButtonDown("Jump"))  //just getkey that's weird, that's suspicious - it was weird and suspicious, changing it to getKeyDown so out player doesn't
            //fly of in the sky
        {
            rb.velocity = new Vector2(rb.velocity.x,14f);    //7 and 1 gravity feels a little smooth(not earth like)
            //.velocity - to move the object in a direction with a certain speed, vector3 is a data holder for the 3 axises(here the data will be the velocity)

            //using the get component in the update is not really resourceful cause the code needs to find the rigidbdy at every frame, so we gonna make a variable 
            //for it.
            //using getButtonDown to use unity's given key stuff, "Jump" instead of "space" - just directly calling the button that is responsible for jump according
            //to unity, can be changed
        }
    }
}
