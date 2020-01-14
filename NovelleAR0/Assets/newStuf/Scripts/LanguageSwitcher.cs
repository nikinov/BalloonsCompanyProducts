using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LocalizationTools;

public class LanguageSwitcher : MonoBehaviour
{
    public void SwitchLanguage(int val){
        switch(val){
            case 0:
            LocalizationManager.instance.LoadLocalizedText("Localisation_EN.json");
            break;
            case 1:
            LocalizationManager.instance.LoadLocalizedText("Localisation_RU.json");
            break;
            case 2:
            LocalizationManager.instance.LoadLocalizedText("Localisation_CZ.json");
            break;
            case 3:
            LocalizationManager.instance.LoadLocalizedText("Localisation_DE.json");
            break;
        }
    }
}
