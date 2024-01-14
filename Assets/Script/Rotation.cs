using UnityEngine;
namespace task1

//The Value must be a Vector3 type and you must be able to change rotation arrount each axies individually.


{
    public class Rotation : MonoBehaviour
    {
        // [SerializeField] должно отображаться в инспекторе Unity, даже если она является приватной.
        [SerializeField] private Vector3 rotateValue = Vector3.zero; // Vector3.zero (0, 0, 0). Vector3 rotateValue (X, Y, Z).
        private void Start()
        {
            Debug.Log("Here we go");
        }

        private void Update()
        {
            Debug.Log("X: " + rotateValue.x);
            Debug.Log("Y: " + rotateValue.y);
            Debug.Log("Z: " + rotateValue.z);
            RotateObject();
        }

        private void RotateObject()
        {
            rotateValue.x = WrapAngle(rotateValue.x);
            rotateValue.y = WrapAngle(rotateValue.y);
            rotateValue.z = WrapAngle(rotateValue.z);

            transform.rotation = Quaternion.Euler(rotateValue * Time.deltaTime);
        }

        private float WrapAngle(float angle) // ankyan parametrer
        {
            angle %= 360;   // -450 
            if (angle > 180)
                angle -= 360;
            else if (angle < -180)
                angle += 360;

            return angle;
        }
    }
}
