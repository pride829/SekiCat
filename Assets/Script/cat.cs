using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    
    public GameObject dest;

    public float attack_speed = 1;

    private float speed = 1;

    private float t;


    // Start is called before the first frame update
    void Start()
    {
        t = 0;
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
        if (t < 2)
        {
            transform.position = sneakyMove(transform.parent.transform.position, dest.transform.position, t / 2);
        }

        // cat status: spawn -> sneaky move -> quick move -> attack with a frequncy -> die or leave

    }

    private Vector3 sneakyMove(Vector3 a, Vector3 b, float perc)
    {
        /* 用sneaky的方式從A點移到B點，等待一段時間，然後return
         * 目前的想法是sneakyMove只需要處理position A到position B
         * 而在哪裡出現則由上層的cat spawner來判斷
         * param: 等待時間
         * 
         * return: 
        */

        //TODO: 一個function來計算目前cat位於何處，目前先用Lerp代替
        return Vector3.Lerp(a, b, perc);
    }

}
