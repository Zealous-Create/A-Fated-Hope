using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class cameraMovement : MonoBehaviour
{

    public float xSens;
    public float ySens;
    public Transform orentation;
    
    float xRotation;
    float yrotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        UnityEngine.Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * xSens;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * ySens;

        xRotation += mouseY;
        yrotation -= mouseX;

        xRotation = Mathf.Clamp(mouseX,-90f,90f);
    }
}
