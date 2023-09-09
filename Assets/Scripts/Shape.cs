using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base class, children of this will inherit the colour change behaviour and need to provide their own implementation of the Move method
public abstract class Shape : MonoBehaviour
{

    private Renderer shapeRenderer;
    private float timeSinceChange = 0.0f;


    // Children class will decide how they move
    // ABSTRACTION - no need to care about details of how they will move
    public abstract void Move();

    public void Start()
    {
        shapeRenderer = GetComponent<Renderer>();
        
    }

    // All classes will inherit the colour change behaviour
    public void Update()
    {
        ColourChange();
    }

    // INHERITANCE
    protected void ColourChange() {
        timeSinceChange += Time.deltaTime;
        if (timeSinceChange > 0.5f)
        {
            Color c = new Color(Random.RandomRange(0, 256) / 256f, Random.RandomRange(0, 256) / 256f, Random.RandomRange(0, 256) / 256f);

            shapeRenderer.material.SetColor("_Color", c);

            timeSinceChange = 0.0f;
        }
    }
}
