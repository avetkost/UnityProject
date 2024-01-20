using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson2
{
    public class Cylinder : VirtualRotate
    {
        protected override void ShapeRotate()
        {
            transform.rotation = Quaternion.Euler(targetRotation.x, transform.eulerAngles.y, transform.eulerAngles.z);
        }
    }
}