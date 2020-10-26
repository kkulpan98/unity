using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie3Skrypt : MonoBehaviour
{
    public float speed;
    private Vector3 leftUp = new Vector3(0, 0, 0);
    private Vector3 rightUp = new Vector3(10, 0, 0);
    private Vector3 rightDown = new Vector3(10, 0, 10);
    private Vector3 leftDown = new Vector3(0, 0, 10);
    float moveX;
    float moveZ;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        moveX = speed * Time.deltaTime;
        moveZ = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (transform.position == leftUp)
        {
            moveX = speed * Time.deltaTime;
            moveZ = 0;
        }
        if (transform.position == rightUp)
        {
            moveX = 0;
            moveZ = speed * Time.deltaTime;
        }
        if (transform.position == rightDown)
        {
            moveX = -speed * Time.deltaTime;
            moveZ = 0;
        }
        if (transform.position == leftDown)
        {
            moveX = 0;
            moveZ = -speed * Time.deltaTime;
        }

        transform.Translate(moveX, 0, moveZ);
    }
}
