using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class cat_spawner : MonoBehaviour
{

    public GameObject cat_prefab;
    public GameObject area0, area1, area2;
    public GameObject[] fur;

    private float initializationTime;

    // The queue is used to spawn cat periodically
    List<float> spawn_queue;
    List<GameObject> spawn_points;
    // Unity doesn't seem to support tuple.
    //Tuple<GameObject, bool> fur;

    bool[] furIsOccupied;
    int furIsOccupiedCount;

    public void Spwan_horde(int number, float last_time, float t)
    {
        /* This function will be called by timer.
         * Param: last_time
         * Param: t: timeSinceLevelLoad - initializationTime
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
        
        // Initiate furIsOccupied
        furIsOccupied = new bool[fur.Length];
        for(int i = 0; i < furIsOccupied.Length; i++)
        {
            furIsOccupied[i] = false;
        }
        furIsOccupiedCount = 0;

        gameobject.transform.Find("ChildName");

        // Testing
        Spwan_horde(5, 5, t);
    }

    void Update()
    {

        float t = Time.timeSinceLevelLoad - initializationTime;
        // Spwan every time slot
        // Do not describe spwaned object behavior, the object's script describe it.

        if (spawn_queue.Any() && spawn_queue[0] < t && furIsOccupiedCount < furIsOccupied.Length)
        {
            spawn_queue.RemoveAt(0);
            GameObject cat = Instantiate(cat_prefab, transform);
            int next_target = (int)Random.Range(0, furIsOccupied.Length);
            while (furIsOccupied[next_target] == true)
            {
                next_target = (int)Random.Range(0, furIsOccupied.Length);
            }

            cat.GetComponent<cat>().dest = fur[next_target];
            furIsOccupiedCount += 1;
        }

    }
}
