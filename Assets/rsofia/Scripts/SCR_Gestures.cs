using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_Gestures : MonoBehaviour {

    public Animator animator;
    public GameObject popUpGreat;
    public Text txtPopUp; 

    public void OnExtendedFingerActivated()
    {
        Debug.Log("Extended finger Activated!");
        animator.SetTrigger("wave");
        OpenPopUp("Wave");
    }

    public void OnExtendedFingerDeactivated()
    {
        Debug.Log("Extended finger Deactivated!");
    }

    public void OnGoodGestureActivated()
    {
        Debug.Log("Good Activated!");
        animator.SetTrigger("jump");
        OpenPopUp("JUMP");
    }

    public void OnGoodGestureDeactivated()
    {
        Debug.Log("Good Dectivated!");
    }


    #region UI
    public void OpenPopUp(string _text)
    {
        popUpGreat.SetActive(true);
        txtPopUp.text = _text;
        StartCoroutine(Fade());
    }
    public void ClosePopUp()
    {
        popUpGreat.SetActive(false);
    }
    IEnumerator Fade()
    {
        yield return new WaitForSeconds(0.75f);
        ClosePopUp();
    }
    #endregion
}
