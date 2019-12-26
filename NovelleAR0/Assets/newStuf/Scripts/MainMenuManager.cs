using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public Animator animator;

    public GameObject MainPanel;
    public GameObject HowToUsePanel;
    public GameObject ContactUsPanel;

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
    }
}
