using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Start is called before the first frame update
public class LookAround : MonoBehaviour
{
    // ruch wokół osi Y będzie wykonywany na obiekcie gracza, więc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)

    public Transform player;
    public float lookScale = 50;

    private Quaternion camRotation;

    void Start()
    {
        // zablokowanie kursora na środku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
        camRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        // pobieramy wartości dla obu osi ruchu myszy
        float mouseXMove = Input.GetAxis("Mouse X") * Time.deltaTime * lookScale;
        //float mouseYMove = Input.GetAxis("Mouse Y") * Time.deltaTime;

        // wykonujemy rotację wokół osi Y
        player.Rotate(Vector3.up * mouseXMove);

        //mouseYMove = Mathf.Clamp(c);

        //// a dla osi X obracamy kamerę
        //transform.Rotate(new Vector3(mouseYMove, 0f, 0f), Space.Self);

        camRotation.x -= Input.GetAxis("Mouse Y") * Time.deltaTime * lookScale;
        camRotation.x = Mathf.Clamp(camRotation.x, -90, 90);

        transform.localRotation = Quaternion.Euler(camRotation.x, camRotation.y, camRotation.z);
    }
}
