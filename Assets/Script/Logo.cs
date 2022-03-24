using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logo : MonoBehaviour
{

    public float minimum = 0.0f;
    public float maximum = 1f;
    public float duration = 1f;
    private float startTime;
    public SpriteRenderer sprite;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        
        // Fade in and fade out
        float t = (Time.time - startTime);

        if(t < duration)
        {
            sprite.color = new Color(1f, 1f, 1f, Mathf.SmoothStep(minimum, maximum, t/duration));
        }else if(t < 2 * duration)
        {
            sprite.color = new Color(1f, 1f, 1f, Mathf.SmoothStep(maximum, minimum, (t-duration)/duration));
        }

        
    }
}
