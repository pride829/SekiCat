using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main_character : MonoBehaviour
{
    public GameObject computer_desk_0, computer_desk_1, computer_desk_2;
    private GameObject now_desk;

    // Start is called before the first frame update
    void Start()
    {

        // This does not seem like the correct way to find object.
        //mc = GameObject.Find("main_character");
    }


    // Update is called once per frame
    void Update()
    {

        // This debug message is not displayed. I wonder why.
        //Debug.Log("I am alive!");

        // Reference transform in the script directly reference the object this script is attached to.


        // Desk should have a function to return the up/down/left/right object.
        if (Input.GetKeyDown("left"))
        {
            now_desk = computer_desk_0;
            transform.position = now_desk.transform.Find("down").transform.position;
        }
        else if (Input.GetKeyDown("down"))
        {
            now_desk = computer_desk_1;
            transform.position = now_desk.transform.Find("down").transform.position;
        }
        else if (Input.GetKeyDown("right"))
        {
            now_desk = computer_desk_2;
            transform.position = now_desk.transform.Find("down").transform.position;
        }
        else if (Input.GetKeyDown("w"))
        {
            transform.position = now_desk.transform.Find("up").transform.position;
        }
        else if (Input.GetKeyDown("a"))
        {
            transform.position = now_desk.transform.Find("left").transform.position;
        }
        else if (Input.GetKeyDown("s"))
        {
            transform.position = now_desk.transform.Find("down").transform.position;
        }
        else if (Input.GetKeyDown("d"))
        {
            transform.position = now_desk.transform.Find("right").transform.position;
        }
    }
}
