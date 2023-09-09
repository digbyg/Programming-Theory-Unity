using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    // POLYMORPHISM
    override public void Move()
    {
        transform.Rotate(0, 45, 0);
    }
}
