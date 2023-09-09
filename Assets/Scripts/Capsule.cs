using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    // POLYMORPHISM
    override public void Move()
    {
        transform.position += Vector3.left;
    }
}
