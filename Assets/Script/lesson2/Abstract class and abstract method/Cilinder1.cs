using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lesson2
{
    public class Cylinder1 : AbstractShape
    {

        protected override void RotateShape()
        {
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, targetRotation.y, transform.eulerAngles.z);
        }
    }

}