using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public float transitionTime = 1f;
    public bool fadeOutOnStart = true;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void LoadLevel(int indexBuild)
    {
        FadeIn();
        StartCoroutine(LoadLevelDelay(indexBuild));
    }

    IEnumerator LoadLevelDelay(int indexBuild)
    {
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(indexBuild);
    }

    public void FadeIn()
    {
        animator.SetTrigger("Fade_in");
    }
}
