using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class healthScript : MonoBehaviour
{
    [SerializeField]
    private int health = 10;
    
    public void takeDamage(int dmg)
    {
        health -= dmg;
        Debug.Log(name + " being attacked");
        if (health <= 0) die();
    }

    void die()
    {
        Destroy(gameObject);
    }
}
