using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BLR.Player
{
    public class PlayerLook : MonoBehaviour
    {
        [SerializeField]
        private new Camera camera;
        private float xRotation= 0f;

        public float sensitivity = 30f;

        public void ProcessLook(Vector2 input)
        {
            float mouseX = input.x;
            float mouseY = input.y;
            xRotation -= (mouseY * Time.deltaTime) * sensitivity;
            xRotation = Mathf.Clamp(xRotation, -80f, 80f);
            camera.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
            transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * sensitivity);
        }
    }
}

