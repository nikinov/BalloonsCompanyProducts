using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    }
    public void Unlock()
    {
        PremButton.SetActive(false);
    }
    private void Awake()
    {
        //if(InAppPurchasing.IsProductOwned(EM_IAPConstants.Product_Premium_Stuff))
        //{
        //    Unlock();
        //}
    }
}
