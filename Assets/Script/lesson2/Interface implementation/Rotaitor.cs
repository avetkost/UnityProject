using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson2
{
    public class Rotaitor : MonoBehaviour
    {
        [SerializeField] private List<GameObject> shapes = new List<GameObject>();
        private List<IRotatable> irotatables = new List<IRotatable>();

        void Awake()
        {
            foreach (var shape in shapes)
            {
                irotatables.Add(shape.GetComponent<IRotatable>());
            }
        }

        void Update()
        {
            foreach (var iRotatable in irotatables)
            {
                iRotatable.Rotate();
            }
        }
    }
}