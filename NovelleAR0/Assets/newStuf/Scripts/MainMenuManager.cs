using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class MainMenuManager : MonoBehaviour
{
    public Animator animator;

    public GameObject PremButton;

    public void LoadGame()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
    public void HowToUse()
    {
        animator.SetInteger("Panels", 1);
    }
    public void ContactUs()
    {
        animator.SetInteger("Panels", 2);
    }
    public void Getpremium()
    {
        animator.SetInteger("Panels", 3);
    }
    public void BackToMainPanel()
    {
        animator.SetInteger("Panels", 0);
        Pause();
    }
    public void Unlock()
    {
        PremButton.SetActive(false);
        PlayerPrefs.SetInt("unlock", 1);
    }
    private void Awake()
    {
        if(PlayerPrefs.GetInt("unlock") == 1)
        {
            Unlock();
        }
        //if(InAppPurchasing.IsProductOwned(EM_IAPConstants.Product_Premium_Stuff))
        //{
        //    Unlock();
        //}

        pause.SetActive(false);
    }
    public void GetRidOfUnlock()
    {
        PlayerPrefs.SetInt("unlock", 0);
    }

    //video
    public RawImage image;
    public RawImage image2;
    public VideoPlayer vid;
    public AudioSource audio;
    public GameObject PlayButton;
    public GameObject pause;

    public void PlayVideo()
    {
        StartCoroutine(PlayVid());
        PlayButton.SetActive(false);

    }
    IEnumerator PlayVid()
    {
        vid.Prepare();
        WaitForSeconds wait = new WaitForSeconds(1);
        while (!vid.isPrepared)
        {
            yield return wait;
            break;
        }
        image.texture = vid.texture;
        vid.Play();
        audio.Play();
        pause.SetActive(true);
    }
    public void Pause()
    {
        PlayButton.SetActive(true);
        vid.Stop();
        audio.Stop();
        pause.SetActive(false);
        PlayButton.SetActive(true);
        image.texture = image2.texture;
    }
}
