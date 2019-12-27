using System;
using System.Collections;
using System.Collections.Generic;
using EasyMobile;
using UnityEngine;
using UnityEngine.UI;

public class SubscibeToPremiumStuff : MonoBehaviour
{
<<<<<<< HEAD

    //[SerializeField] private Text dedugText;
=======
    
>>>>>>> 2ad84c9addab7aabbb0b11829abc0416ae76e6a8
    private void Start()
    {
        // Check if initialization has completed (the user has been authenticated)
        // Check if the IAP module has been initialized
        bool isInitialized = InAppPurchasing.IsInitialized();
    }
    
    void Awake()
    {
        if (!RuntimeManager.IsInitialized())
            RuntimeManager.Init();
    }

    private void OnEnable()
    {
        InAppPurchasing.PurchaseCompleted += subsS;
        InAppPurchasing.PurchaseFailed += subsF;
    }

    private void OnDisable()
    {
        InAppPurchasing.PurchaseCompleted -= subsS;
        InAppPurchasing.PurchaseFailed -= subsF;
    }

    public void Subscribe()
    {
        InAppPurchasing.Purchase(EM_IAPConstants.Product_Premium_stuff);
    }

    private void subsS(IAPProduct product)
    {
<<<<<<< HEAD
        //dedugText.text += "+";
=======
        
>>>>>>> 2ad84c9addab7aabbb0b11829abc0416ae76e6a8
    }

    private void subsF(IAPProduct product)
    {
<<<<<<< HEAD
        //dedugText.text += "-";
=======
        
>>>>>>> 2ad84c9addab7aabbb0b11829abc0416ae76e6a8
    }
    
}
