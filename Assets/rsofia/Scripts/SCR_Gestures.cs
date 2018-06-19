using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_Gestures : MonoBehaviour {

    public Animator animator;
    public GameObject popUpGreat;
    public Text txtPopUp;

    #region GESTURES

        #region HAND GUN 
        public void OnExtendedFingerActivated()
        {
            Debug.Log("Hand gun, Extended finger Activated!");
            animator.SetTrigger("wave");
            OpenPopUp("Wave");
        }

        public void OnExtendedFingerDeactivated()
        {
            Debug.Log("Extended finger Deactivated!");
        }
    #endregion

        #region THUMBS UP
        public void OnGoodGestureActivated()
        {
            Debug.Log("Thumbs Up Activated!");
            animator.SetTrigger("jump");
            OpenPopUp("JUMP");
        }

        public void OnGoodGestureDeactivated()
        {
            Debug.Log("Good Dectivated!");
        }
        #endregion

    
        #region PUNCH
        public void OnPunchActivated()
        {
            Debug.Log("Punched!");
        animator.SetTrigger("brazos");
        OpenPopUp("¡Mueve los brazos!");
        }
        public void OnPunchDeactivated()
        {
            Debug.Log("Punch ended");
        }
    #endregion

    #region ZOOM
    public void OnZoomIn()
    {
        Debug.Log("Zoom in");
        if (Camera.main.fieldOfView >= 15)
        {
            Camera.main.fieldOfView -= 3;
            OpenPopUp("Zoom in");
        }
    }
    public void OnZoomOut()
    {
        Debug.Log("Zoom Out");
        if (Camera.main.fieldOfView <= 150)
        {
            Camera.main.fieldOfView += 3;
            OpenPopUp("Zoom out");
        }
    }
    #endregion

    #endregion
    

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
