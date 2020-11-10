using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveTowards : MonoBehaviour
{
    public GameObject platform;
    public float elevatorSpeed = 2f;
    private bool isRunning = false;
    private Transform oldParent;
    private bool isRunningForward = true;
    private bool isRunningBackward = false;
    private int towardsPoint = 0;

    public Vector3[] points;

    void FixedUpdate()
    {
        if (isRunning)
        {
            if (platform.transform.position != points[towardsPoint])
            {
                // to poruszaj sie w strone punktu
                platform.transform.position = Vector3.MoveTowards(platform.transform.position, points[towardsPoint], elevatorSpeed * Time.deltaTime);
            }
            else
            {
                if (isRunningForward && !isRunningBackward && platform.transform.position != points[points.Length - 1])
                {
                    towardsPoint++;
                    Debug.Log(towardsPoint);
                }
                else if (!isRunningForward && isRunningBackward && platform.transform.position != points[0])
                {
                    towardsPoint--;
                    Debug.Log(towardsPoint);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player wszedł na windę.");

            oldParent = other.gameObject.transform.parent;
            other.transform.parent = platform.transform;

            if (platform.transform.position == points[points.Length - 1])
            {
                isRunningBackward = true;
                isRunningForward = false;
            }
            else if (platform.transform.position == points[0])
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

            other.transform.parent = oldParent;

            isRunning = false;
        }
    }
}
