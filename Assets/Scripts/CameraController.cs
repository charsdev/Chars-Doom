using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private float xRotation;
    [SerializeField] private CharacterMotor characterMotor;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -70, 70);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        characterMotor.transform.Rotate(Vector3.up * mouseX);
    }
}
