using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVel;
    public float panSpeed = 20f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        characterMovement();
        if (Input.GetKeyDown(KeyCode.Space))
            touchCat();
    }

    void characterMovement()
    {
        Vector3 pos = transform.position;

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        controller.Move(move * Time.deltaTime * panSpeed);
    }

    void touchCat()
    {
        Debug.Log("Hand reached out.");
    }
}
