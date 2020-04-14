using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    public float CameraSpeed = 120.0f;
    public GameObject CameraFollowObj;
    Vector3 FollowPos;
    public float clampAngle = 80.0f;
    public float inputSensitivity = 150.0f;
    //public GameObject Camera;
    //public GameObject Player;
    public float cameraDistanceXPlayer;
    public float cameraDistanceYPlayer;
    public float cameraDistanceZPlayer;
    public float mouseX;
    public float mouseY;
    public float finalInputX;
    public float finalInputZ;
    public float smoothX;
    public float smoothY;
    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Start()
    {
        Vector3 rotation = transform.localRotation.eulerAngles;
        rotationY = rotation.y;
        rotationX = rotation.x;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float inputX = Input.GetAxis("RightStickHorizontal");
        float inputZ = Input.GetAxis("RightStickVertical");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");
        finalInputX = inputX + mouseX;
        finalInputZ = inputZ + mouseY;

        rotationY += finalInputX * inputSensitivity * Time.deltaTime;
        rotationX += finalInputZ * inputSensitivity * Time.deltaTime;

        rotationX = Mathf.Clamp(rotationX, -clampAngle, clampAngle);

        Quaternion localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);
        transform.rotation = localRotation;
    }

    void LateUpdate()
    {
        CameraUpdate();
    }

    void CameraUpdate()
    {
        Transform target = CameraFollowObj.transform;

        float step = CameraSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

}
