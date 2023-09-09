using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{

    override public void Move() {
        transform.position += Vector3.forward;
    }
}
