using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// Basé sur : https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/
/// </summary>
public class Timer : MonoBehaviour
{
    public Text timerText;
    //In Seconds
    public float timeRemaining = 300;
    public bool timerRunning = false;

    private void Awake()
    {
        if (timerText == null)
            Debug.LogWarning("Timer has no display text", this);
    }

    // Start is called before the first frame update
    void Start()
    {
        timerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                if(timerText != null)
                    timerText.text = TimerInMinutes();
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerRunning = false;
                StartCoroutine("EndTimer");
                GameManager.Instance.EndExpertise();
            }
        }
    }

    public string TimerInMinutes()
    {
        return string.Format("{0:00} : {1:00}", Mathf.FloorToInt((timeRemaining +1) / 60), Mathf.FloorToInt((timeRemaining+1) % 60));
    }

    IEnumerator EndTimer()
    {
        yield return new WaitForSeconds(1.5f);
        this.transform.DOLocalMoveY(this.transform.localPosition.y + 200, 1.5f);
    }
}
