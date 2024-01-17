using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lesson2
{
    public class Capsule1 : AbstractShape
    {     
        protected override void RotateShape()
        {
            transform.rotation = Quaternion.Euler(targetRotation.x, transform.eulerAngles.y, transform.eulerAngles.z);
        }
    }

}