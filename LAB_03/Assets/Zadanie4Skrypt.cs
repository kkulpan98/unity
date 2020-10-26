using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie4Skrypt : MonoBehaviour
{
    public Collider collider;
    public bool dotknietoPrzeszkody = false;

    void OnCollisionEnter(Collision collision)
    {
        //if (collider.gameObject.tag == "Przeszkoda")
        //    dotknietoPrzeszkody = true;
        //else
        //    dotknietoPrzeszkody = false;
        dotknietoPrzeszkody = true;
    }

    //void OnCollisionExit(Collision collision)
    //{
    //    dotknietoPrzeszkody = false;
    //}
}
