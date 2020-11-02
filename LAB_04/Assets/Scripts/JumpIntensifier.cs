using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpIntensifier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnControllerColliderHit(ControllerColliderHit col)
    {
        if (col.gameObject.tag == "JumpIntensifier")
            Debug.Log("Wyzej skacz");
    }
}
