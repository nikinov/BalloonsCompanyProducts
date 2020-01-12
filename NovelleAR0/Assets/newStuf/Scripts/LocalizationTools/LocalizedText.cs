using UnityEngine;
using UnityEngine.UI;

namespace LocalizationTools
{
    public class LocalizedText : MonoBehaviour 
    {
        
        public string key;

        private Text label;

        private void Start() {
            label = GetComponent<Text>();
            LocalizationManager.instance.OnLocalisedTextUpdated += UpdateLocalizationText;
        }

        private void UpdateLocalizationText(){
            if(label != null){
                label.text = LocalizationManager.instance.GetLocalisedValue(key);
            }
        }

        private void OnDestroy() {
            LocalizationManager.instance.OnLocalisedTextUpdated -= UpdateLocalizationText;
        }

    }
}

    
    

