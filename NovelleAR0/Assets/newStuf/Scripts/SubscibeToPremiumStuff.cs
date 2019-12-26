using System;
using System.Collections;
using System.Collections.Generic;
using EasyMobile;
using UnityEngine;
using UnityEngine.UI;

public class SubscibeToPremiumStuff : MonoBehaviour
{

    [SerializeField] private Text dedugText;
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
        InAppPurchasing.Purchase(EM_IAPConstants.Product_Premium_Stuff);
    }

    private void subsS(IAPProduct product)
    {
        dedugText.text += "+";
    }

    private void subsF(IAPProduct product)
    {
        dedugText.text += "-";
    }
    
}
