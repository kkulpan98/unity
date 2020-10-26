using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie2Skrypt : MonoBehaviour
{
    public float speed;
    private Vector3 start = new Vector3(0, 0, 0);
    private Vector3 end = new Vector3(10, 0, 0);
    float move;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        move = -speed * Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (transform.position == start || transform.position == end)
        {
            move = -move;
        }

        transform.Translate(move, 0, 0);
    }
}
