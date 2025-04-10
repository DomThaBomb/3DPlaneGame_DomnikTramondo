using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerPawn pawn;

    // KeyCode Controller
    public KeyCode moveForward;
    public KeyCode moveBackward;
    public KeyCode yawClockwise;
    public KeyCode yawCounterClockwise;
    public KeyCode rollClockwise;
    public KeyCode rollCounterClockwise;
    public KeyCode pitchClockwise;
    public KeyCode pitchCounterClockwise;

    // KeyCode Camera Component
    public KeyCode reduceCameraOffset;
    public KeyCode increaseCameraOffset;

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
        if (Input.GetKey(moveForward))
        {
            // move forward

            pawn.MoveForward();
        }
        if (Input.GetKey(moveBackward))
        {
            // move backward

            pawn.MoveBackward();
        }
        if (Input.GetKey(yawClockwise))
        {
            // yaw clockwise

            pawn.YawClockwise();
        }
        if (Input.GetKey(yawCounterClockwise))
        {
            // yaw counterclockwise

            pawn.YawCounterClockwise();
        }
        if (Input.GetKey(rollClockwise))
        {
            // roll clockwise

            pawn.RollClockwise();
        }
        if (Input.GetKey(rollCounterClockwise))
        {
            // roll counterclockwise

            pawn.RollCounterClockwise();
        }
        if (Input.GetKey(pitchClockwise))
        {
            // roll clockwise

            pawn.PitchClockwise();
        }
        if (Input.GetKey(pitchCounterClockwise))
        {
            // roll counterclockwise

            pawn.PitchCounterClockwise();
        }

        if (Input.GetKey(reduceCameraOffset))
        {
            pawn.DecreaseCamOffset();
        }
        if (Input.GetKey(increaseCameraOffset))
        {
            pawn.IncreaseCamOffset();
        }
    }
}

