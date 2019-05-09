using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_GestureController : MonoBehaviour {

    public Animator HologramAnimator;

    public void OnTwoFingersUpActivated()
    {
        Debug.Log("Two Fingers");
        HologramAnimator.SetTrigger("TwoFingers");
    }

    public void OnMetalPoseActivated()
    {
        Debug.Log("Metal Pose");

        HologramAnimator.SetTrigger("Metal");

    }

    public void OnPinchActivated()
    {
        Debug.Log("Pinch");

        HologramAnimator.SetTrigger("Pinch");

    }
}
