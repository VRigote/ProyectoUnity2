using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Detectar si la tecla "q" está siendo presionada
        bool forwardPressed = Input.GetKey("q");

        // Si la tecla "q" está presionada
        if (forwardPressed)
        {
            // Establecer el trigger "StartWarmup"
            animator.SetTrigger("StartWarmup");
        }
        else
        {
            // Reiniciar el trigger "StartWarmup"
            animator.ResetTrigger("StartWarmup");
        }

        // Detectar si la tecla "w" está siendo presionada
        bool dancePressed = Input.GetKey("w");

        // Si la tecla "w" está presionada
        if (dancePressed)
        {
            // Establecer el trigger "DoSimpleDance"
            animator.SetTrigger("DoSimpleDance");
        }
        else
        {
            // Reiniciar el trigger "DoSimpleDance"
            animator.ResetTrigger("DoSimpleDance");
        }

        // Detectar si la tecla "e" está siendo presionada
        bool advancedMovePressed = Input.GetKey("e");

        // Si la tecla "e" está presionada
        if (advancedMovePressed)
        {
            // Establecer el trigger "DoAdvancedMove"
            animator.SetTrigger("DoAdvancedMove");
        }
        else
        {
            // Reiniciar el trigger "DoAdvancedMove"
            animator.ResetTrigger("DoAdvancedMove");
        }

        // Detectar si la tecla "r" está siendo presionada
        bool finalMovePressed = Input.GetKey("r");

        // Si la tecla "r" está presionada
        if (finalMovePressed)
        {
            // Establecer el trigger "DoFinalMove"
            animator.SetTrigger("DoFinalMove");
        }
        else
        {
            // Reiniciar el trigger "DoFinalMove"
            animator.ResetTrigger("DoFinalMove");
        }
    }
}
