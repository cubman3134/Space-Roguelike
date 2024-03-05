using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    public GameObject Camera;
    private float _cameraSpeed = 10.0f;
    private float _scrollSpeed = 600.0f;
    private float _maxCameraZ = -10;
    private float _minCameraZ = -40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var amountToMove = new Vector3();
        if (Input.GetKey(KeyCode.D))
        {
            amountToMove += new Vector3(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            amountToMove += new Vector3(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            amountToMove += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            amountToMove += new Vector3(1, 0, 0);
        }
        var scrollAmount = Input.GetAxis("Mouse ScrollWheel");
        if (Input.GetAxis("Mouse ScrollWheel") != 0f) // forward
        {
            amountToMove += new Vector3(0, 0, scrollAmount * _scrollSpeed);
        }

        if (amountToMove != default)
        {
            var amountToAdd = amountToMove * Time.deltaTime * _cameraSpeed;
            var newPosition = Camera.transform.position + amountToAdd;
            if (newPosition.z < _minCameraZ)
            {
                newPosition = new Vector3(newPosition.x, newPosition.y, _minCameraZ);
            }
            else if (newPosition.z > _maxCameraZ)
            {
                newPosition = new Vector3(newPosition.x, newPosition.y, _maxCameraZ);
            }
            Camera.transform.position = newPosition;
        }
    }
}
