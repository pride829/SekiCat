using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthScript : MonoBehaviour
{
    [SerializeField]
    private int health = 10;

    public void takeDamage(int dmg)
    {
        health -= dmg;
        if (health <= 0) die();
    }

    void die()
    {
        Destroy(gameObject);
    }
}
