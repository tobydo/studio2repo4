using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerjump : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter(Collider other)
    {
            myAnimationController.SetBool("Trigger", true);
    }
}
