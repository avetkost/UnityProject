using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lesson2
{
    public class Cube1 : Shape
    {      
        protected override void RotateShape()
        {
            transform.rotation = Quaternion.Euler(targetRotation);
        }
    }

}
