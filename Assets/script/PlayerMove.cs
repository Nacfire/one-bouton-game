using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
     // Vitesse initiale de la boule
    public float initialSpeed = 2f;

    // Facteur d'accélération exponentielle
    public float accelerationFactor = 1.1f;

    // Direction de déplacement de la boule
    public Vector3 direction = Vector3.forward;

    // Vitesse actuelle de la boule
    private float currentSpeed;

    // Booléen pour savoir si la boule est en mouvement ou non
    private bool isMoving = true;

    void Start()
    {
        // Initialise la vitesse de la boule à la vitesse initiale
        currentSpeed = initialSpeed;
    }

    void Update()
    {
        // Si la boule est en mouvement, déplacez-la dans la direction actuelle à la vitesse actuelle
        if (isMoving)
        {
            transform.Translate(direction * currentSpeed * Time.deltaTime);
            // Accélère la boule exponentiellement
            currentSpeed *= accelerationFactor;
        }

        // Si la touche Espace est enfoncée, arrêtez la boule
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isMoving = !isMoving;
        }

        // Si la touche Espace est enfoncée, arrêtez la boule
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isMoving = true;
        }
    }
}
