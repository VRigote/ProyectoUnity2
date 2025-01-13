using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightFollow : MonoBehaviour
{
    public Transform character;  // Referencia al personaje
    public float smoothSpeed = 0.125f;  // Suaviza el movimiento de la luz

    // Update is called once per frame
    void Update()
    {
        // Hacer que la luz siga al personaje
        Vector3 desiredPosition = new Vector3(character.position.x, transform.position.y, character.position.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}

