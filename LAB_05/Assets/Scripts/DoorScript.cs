using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private float openPosition;
    private float closePosition;
    private bool isOpening;
    private bool isClosing;
    public float distance = 2.0f;
    public float doorSpeed = 2.0f;
    public GameObject door;

    void Start()
    {
        openPosition = door.transform.position.x + distance;
        closePosition = door.transform.position.x;
    }

    void FixedUpdate()
    {
        if (isOpening && door.transform.position.x <= openPosition)
        {
            Vector3 move = door.transform.right * doorSpeed * Time.deltaTime;
            door.transform.Translate(move);
        }
        else if (isClosing && door.transform.position.x >= closePosition)
        {
            Vector3 move = door.transform.right * doorSpeed * Time.deltaTime;
            door.transform.Translate(-move);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player otwiera drzwi");

            isClosing = false;
            isOpening = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player zamyka drzwi.");

            isClosing = true;
            isOpening = false;
        }
    }
}
