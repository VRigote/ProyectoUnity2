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
        // Detectar si la tecla "q" est� siendo presionada
        bool forwardPressed = Input.GetKey("q");

        // Si la tecla "q" est� presionada
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

        // Detectar si la tecla "w" est� siendo presionada
        bool dancePressed = Input.GetKey("w");

        // Si la tecla "w" est� presionada
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

        // Detectar si la tecla "e" est� siendo presionada
        bool advancedMovePressed = Input.GetKey("e");

        // Si la tecla "e" est� presionada
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

        // Detectar si la tecla "r" est� siendo presionada
        bool finalMovePressed = Input.GetKey("r");

        // Si la tecla "r" est� presionada
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
