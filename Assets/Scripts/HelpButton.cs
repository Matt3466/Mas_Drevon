using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HelpButton : MonoBehaviour
{
    public CanvasGroup helpDisplay;

    bool isHelpDisplayed = false;

    private void Start()
    {
        if(helpDisplay == null)
        {
            Debug.LogWarning("Help display not defined !");
            this.gameObject.SetActive(false);
        }

        ToggleHelpDisplay();
    }

    public void ToggleHelpDisplay()
    {
        if(!isHelpDisplayed)
        {
            GameManager.Instance.DisplayAllPotentiometer(true);
            helpDisplay.DOFade(1f, 0.5f);
        }
        else
        {
            GameManager.Instance.DisplayAllPotentiometer(false);
            helpDisplay.DOFade(0f, 0.5f);
        }

        isHelpDisplayed = !isHelpDisplayed;
    }
}
