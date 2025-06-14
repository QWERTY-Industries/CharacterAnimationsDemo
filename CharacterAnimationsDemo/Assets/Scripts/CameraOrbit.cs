using UnityEngine;
using UnityEngine.InputSystem;

public class CameraOrbit : MonoBehaviour
{
    [SerializeField] Transform playerRef; //Object to orbit around
    [SerializeField] float rotateAmount; //Amount to rotate

    void Awake()
    {
        transform.parent = playerRef.transform; //Parent the camera to the player in order to orbit around the player even when the player has moved
    }

    void Update()
    {
        float mouseX = Mouse.current.delta.x.ReadValue(); //Get mouse x movement from the input system asset
        if (mouseX != 0) //Make sure there is mouse x movement
        {
            transform.RotateAround(playerRef.position, Vector3.up * mouseX, rotateAmount * Time.deltaTime); //Apply orbit rotation based on mouse x movement
        }
    }
}
