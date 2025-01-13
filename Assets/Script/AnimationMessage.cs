using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationMessage : MonoBehaviour
{
    public Animator animator;  // Referencia al Animator
    public Text messageText;   // Referencia al texto de la UI

    void Update()
    {
        // Verifica el estado actual de la animación y actualiza el mensaje de la UI
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Warmup"))
        {
            messageText.text = "¡Calentando!";
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("DoSimpleDance"))
        {
            messageText.text = "¡Entrando en el ritmo!";
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("DoAdvancedMove"))
        {
            messageText.text = "¡Técnica increíble!";
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("DoFinalMove"))
        {
            messageText.text = "¡Showstopper!";
        }
        else
        {
            messageText.text = "";  // Si no hay animación, no mostrar mensaje
        }
    }
}
