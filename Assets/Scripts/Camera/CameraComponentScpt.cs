using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraComponentScpt : MonoBehaviour
{
    // Transforms
    public Transform cameraTransform;
    public Transform targetTransform;

    // Offsets
    public float minOffset;
    public float maxOffset;
    private float currentOffset;

    // Start is called before the first frame update
    void Start()
    {
        currentOffset = minOffset;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveTransform = targetTransform.position - cameraTransform.position;

        cameraTransform.LookAt(targetTransform);
    }

    public void ChangeCameraOffset(float amountOfOffset)
    {
        currentOffset += amountOfOffset * Time.deltaTime;

        currentOffset = Mathf.Clamp(currentOffset, minOffset, maxOffset);
    }
}
