using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{

    private Renderer shapeRenderer;
    private float timeSinceChange = 0.0f;

    public abstract void Move();

    public void Start()
    {
        shapeRenderer = GetComponent<Renderer>();
        
    }

    public void Update()
    {
        timeSinceChange += Time.deltaTime;
        if (timeSinceChange > 0.5f)
        {
            Color c = new Color(Random.RandomRange(0, 256) / 256f, Random.RandomRange(0, 256) / 256f, Random.RandomRange(0, 256) / 256f);

            shapeRenderer.material.SetColor("_Color", c);

            timeSinceChange = 0.0f;
        }
    }
}
