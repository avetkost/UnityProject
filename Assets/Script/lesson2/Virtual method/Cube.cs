using System;
using System.Collections;
using System.Collections.Generic;
using Lesson2;
using UnityEngine;

namespace ImplementVirtual
{
    public class Cube : VirtualRotate
    {
        protected override void ShapeRotate()
        {            
            base.ShapeRotate();
        }
    }
}