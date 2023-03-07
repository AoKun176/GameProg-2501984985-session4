using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator playerAnimator;
    public GameObject rawImageVideo;
    public SceneChange Gs;

    private void Start()
    {
        rawImageVideo.SetActive(false);
    }
    public void playerAttack()
    {
        playerAnimator.SetTrigger("isAttack");
    }
    public void InvokeScene()
    {
        Invoke("playEndScene", 2.0f);
    }

    public void playEndScene()
    {
        rawImageVideo.SetActive(true);
    }

    public void CallChangeSceneAfterSeconds()
    {
        StartCoroutine("WaitAndChange");
    }
    IEnumerator WaitAndChange()
    {
        
        yield return new WaitForSeconds(11.0f);
        Gs.ChangeScene("Menu");
    }
}

