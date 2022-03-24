using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    
    public GameObject dest;
    public float attack_speed = 1;

    private float speed = 3.0f;
    private SpriteRenderer sprite_renderer;

    private float t;

    enum Status
    {
        Moving,
        Attacking
    }

    private Status status;

    void Start()
    {
        // Initialize
        t = 0;
        status = Status.Moving;
        sprite_renderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime應該代表每個frame之間的時間差
        t += Time.deltaTime * speed;

        // How to describe state? If/else seems sloppy.

        // I am going to need:

        // Cat spwaner(Static, 4)
        // Randomize cat spawn
        // Where cat spawn, time
        // Where cat heading
        //  Start and end point of cat sneaky move
        //  Start and end point of cat quick move
        //  Cat damaging object
        if (status == Status.Moving)
        {
            float step = speed * Time.deltaTime; // calculate distance to move

            // Change cat direction
            if(transform.position[0] < dest.transform.position[0])
            {
                sprite_renderer.flipX = true;
            }
            else
            {
                sprite_renderer.flipX = false;
            }
            
            transform.position = Vector3.MoveTowards(transform.position, dest.transform.position, step);

        }

        // cat status: spawn -> sneaky move -> quick move -> attack with a frequncy -> die or leave

    }

}
