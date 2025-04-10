using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPawn : MonoBehaviour
{
    public Rigidbody rb;

    public float speedster;

    public Transform tf;

    public float force;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovePlease(Vector3 direction)
    {
        rb.AddForce(tf.forward * force);
    }

    public void MoveTransformers(Vector3 direction)
    {
        tf.position += direction * speed * Time.deltaTime;
    }
}
