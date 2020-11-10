using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public GameObject platform;
    public float elevatorSpeed = 2f;
    private bool isRunning = false;
    public float distance = 6.6f;
    private bool isRunningForward = true;
    private bool isRunningBackward = false;
    private float backwardPosition;
    private float forwardPosition;
    private Transform oldParent;

    void Start()
    {
        forwardPosition = platform.transform.position.x + distance;
        backwardPosition = platform.transform.position.x;
    }

    void FixedUpdate()
    {
        if (isRunningForward && platform.transform.position.x >= forwardPosition)
        {
            isRunningBackward = true;
            isRunningForward = false;
        }
        else if (isRunningBackward && platform.transform.position.x <= backwardPosition)
        {
            isRunningBackward = true;
            isRunningForward = false;
            isRunning = false;
        }

        if (isRunning)
        {
            if (isRunningForward)
            {
                Vector3 move = platform.transform.right * elevatorSpeed * Time.deltaTime;
                platform.transform.Translate(move);
            }
            if (isRunningBackward)
            {
                Vector3 move = -platform.transform.right * elevatorSpeed * Time.deltaTime;
                platform.transform.Translate(move);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player wszedł na windę.");

            oldParent = other.gameObject.transform.parent;
            other.gameObject.transform.parent = transform;

            if (platform.transform.position.x >= forwardPosition)
            {
                isRunningBackward = true;
                isRunningForward = false;
            }
            else if (platform.transform.position.x <= backwardPosition)
            {
                isRunningForward = true;
                isRunningBackward = false;
            }
            isRunning = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player zszedł z windy.");

            other.gameObject.transform.parent = oldParent;
            isRunning = false;
        }
    }
}