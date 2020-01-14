using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LocalizationTools;
using UnityEngine.UI;

public class LanguageSwitcher : MonoBehaviour
{

    private Dropdown dropdown;

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

    private void Awake() {
        dropdown = GetComponent<Dropdown>();
    }

    private void Start() {
        if(PlayerPrefs.HasKey("Language") && dropdown != null){
            string val = PlayerPrefs.GetString("Language");

            dropdown.value = LocalisationFileToInt(val);
        }
    }

    private int LocalisationFileToInt(string val){

        switch(val){
            case "Localisation_EN.json":
                return 0;
            case "Localisation_RU.json":
                return 1;
            case "Localisation_CZ.json":
                return 2;
            case "Localisation_DE.json":
                return 3;
        }

        return 0;
    }
}
