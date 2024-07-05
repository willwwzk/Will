using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour{
    public Transform player;
    private float mouseX, mouseY;
    public float mouseSensitivity;
    private void Update (){
        mouseX = Input.GetAxis("Mouse X")*mouseSensitivity*Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y")*mouseSensitivity*Time.deltaTime;
        player.Rotate(Vector3.up*mouseX);
        transform.localRotation = Quaternion.Euler(-mouseY,0,0);
    }
}
