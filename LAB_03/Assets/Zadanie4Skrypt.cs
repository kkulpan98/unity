using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie4Skrypt : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Przeszkoda")
            Debug.Log("Dotknieto przeszkody");
    }

}
