using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    [SerializeField]
    private List<Shape> shapes = new List<Shape>();


    // Update is called once per frame
    public void ButtonPressed()
    {
        for (int i = 0; i < shapes.Count; i++)
        {
            shapes[i].Move();
        }
    }
}
