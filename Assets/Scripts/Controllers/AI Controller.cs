using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public AIPawn pawn;

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    public void ProcessInputs()
    {
        Vector3 directiontoShip1 = target.position - pawn.transform.position;

        directiontoShip1 = directiontoShip1.normalized;

        pawn.MovePlease(directiontoShip1);
    }

    public void MoveTransformers()
    {
        Vector3 directiontoShip1 = target.position - pawn.transform.position;

        directiontoShip1 = directiontoShip1.normalized;


    }
}
