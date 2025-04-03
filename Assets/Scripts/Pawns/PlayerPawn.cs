using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPawn : MonoBehaviour
{

    public Rigidbody rb;
    public Transform tf;

    // Camera Component
    public CameraComponentScpt cameraComponent;

    public float forceMagnitude;

    public float rotationSpeed;

    public float CamOffsetChangeRate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();

        cameraComponent = GetComponent<CameraComponentScpt>();
    }

    public void MoveForward()
    {
        // Debug.Log("move forward");

        if (rb != null)
        {
            rb.AddForce(tf.forward * forceMagnitude);
        }
    }

    public void MoveBackward()
    {
        // Debug.Log("move backward");

        if (rb != null)
        {
            rb.AddForce(-tf.forward * forceMagnitude);
        }
    }

    public void YawClockwise()
    {
        Debug.Log("yaw clockwise");

        if (tf != null)
        {
            tf.Rotate(new Vector3(0,1,0) * rotationSpeed * Time.deltaTime);
        }
    }
    
    public void YawCounterClockwise()
    {
        Debug.Log("yaw Counterclockwise");

        if (tf != null)
        {
            tf.Rotate(new Vector3(0,0,1) * -rotationSpeed * Time.deltaTime);
        }
    }

    public void RollClockwise()
    {
        Debug.Log("roll clockwise");

        if (tf != null)
        {
            tf.Rotate(new Vector3(0, 0, 1) * rotationSpeed * Time.deltaTime);
        }
    }

    public void RollCounterClockwise()
    {
        Debug.Log("roll counterclockwise");

        if (tf != null)
        {
            tf.Rotate(new Vector3(0, 0, 1) * -rotationSpeed * Time.deltaTime);
        }
    }

    public void PitchClockwise()
    {
        Debug.Log("pitchClockwise");

        if (tf != null)
        {
            tf.Rotate(new Vector3(1, 0, 0) * rotationSpeed * Time.deltaTime);
        }
    }

    public void PitchCounterClockwise()
    {
        Debug.Log("pitch counterclockwise");

        if (tf != null)
        {
            tf.Rotate(new Vector3(1, 0, 0) * -rotationSpeed * Time.deltaTime);
        }
    }

    public void IncreaseCamOffset()
    {
        cameraComponent.ChangeCameraOffset(CamOffsetChangeRate);
    }

    public void DecreaseCamOffset()
    {
        cameraComponent.ChangeCameraOffset(CamOffsetChangeRate);
    }
}
