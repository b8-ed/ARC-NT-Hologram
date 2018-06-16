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
            animator.SetTrigger("Wave");
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

        #region PEACE SIGN
        public void OnPeaceSignActivated()
        {
            Debug.Log("Peace sign");
            OpenPopUp("Peace Sign");
        }

        public void OnPeaceSignDeactivated()
        {
            Debug.Log("Deactivated peace sign");
        }

    #endregion

        #region PUNCH
        public void OnPunchActivated()
        {
            Debug.Log("Punched!");
            OpenPopUp("PUNCH");
        }
        public void OnPunchDeactivated()
        {
            Debug.Log("Punch ended");
        }
    #endregion

        #region SEPARATE PALMS
        public void OnSeparatePalmsActivate()
        {
        Debug.Log("Zoom in w separate palms");
        }

        public void OnSeparatePalmsDeactivate()
        {
            Debug.Log("Zoom out");
        }
    #endregion

    #region ZOOM IN
    public void OnZoomIn()
    {
        Debug.Log("Zoom in");
        if(Camera.main.fieldOfView >= 15)
            Camera.main.fieldOfView -= 3;
    }
    public void OnZoomOut()
    {
        Debug.Log("Zoom Out");
        if (Camera.main.fieldOfView <= 150)
            Camera.main.fieldOfView += 3;
    }
    #endregion

    #endregion

    public void HandNearSomething()
    {
        Debug.Log("Hand Near Something");
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
