using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class area : MonoBehaviour
{

    public GameObject up_furniture, down_furniture, left_furniture, right_furniture;

    public GameObject GetFurniture(string loc)
    {
        /* Return furniture based on location.
         * 
        */
        if (loc.Equals("up"))
        {
            return up_furniture;
        }
        if (loc.Equals("down"))
        {
            return down_furniture;
        }
        if (loc.Equals("left"))
        {
            return left_furniture;
        }
        if (loc.Equals("right"))
        {
            return right_furniture;
        }

        return down_furniture;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
