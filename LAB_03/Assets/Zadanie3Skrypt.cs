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

        //if (transform.position == leftUp)
        //{
        //    transform.localRotation = Quaternion.Euler(90, 0f, 0f);
        //    moveX = speed * Time.deltaTime;
        //    moveZ = 0;
        //}
        //if (transform.position == rightUp)
        //{
        //    transform.localRotation = Quaternion.Euler(90, 0f, 0f);
        //    moveX = 0;
        //    moveZ = speed * Time.deltaTime;
        //}
        //if (transform.position == rightDown)
        //{
        //    moveX = -speed * Time.deltaTime;
        //    moveZ = 0;
        //}
        //if (transform.position == leftDown)
        //{
        //    moveX = 0;
        //    moveZ = -speed * Time.deltaTime;
        //}

        if (transform.position == leftUp || transform.position == rightUp || transform.position == leftDown || transform.position == rightDown)
        {
            transform.Rotate(0f, 270f, 0f, Space.Self);
        }

        transform.Translate(moveX, 0, moveZ);
    }
}
