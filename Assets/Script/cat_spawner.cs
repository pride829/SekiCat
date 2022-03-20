using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class cat_spawner : MonoBehaviour
{

    public GameObject cat_prefab;

    private float initializationTime;

    // The queue is used to spawn cat periodically
    List<float> spawn_queue;

    public void Spwan_horde(int number, float last_time, float t)
    {
        /* This function will be called by timer.
         * Param: last_time
        */

        for(int i = 0; i < number; i++)
        {
            spawn_queue.Add(t + last_time * ((float)i / number));
        }
    }

    void Start()
    {
        
        //TODO: I want to assign the cat_prefab at runtime. But this will return null instead. I'll just assign with my hand right now.
        //cat_prefab = Resources.Load<GameObject>("Prefabs/cat");

        initializationTime = Time.timeSinceLevelLoad;
        float t = Time.timeSinceLevelLoad - initializationTime;
        spawn_queue = new List<float>();
        Spwan_horde(5, 5, t);

        for (int i = 0; i < spawn_queue.Count; i++)
        {
            Debug.Log(spawn_queue[i]);
        }

    }

    void Update()
    {

        float t = Time.timeSinceLevelLoad - initializationTime;
        // Spwan every time 時間區塊，
        // Do not describe spwaned object behavior, the object's script describe it.
        
        if (spawn_queue.Any() && spawn_queue[0] < t)
        {
            spawn_queue.RemoveAt(0);
            GameObject cat = Instantiate(cat_prefab, transform);
            cat.GetComponent<cat>().dest = gameObject;
        }

    }
}
