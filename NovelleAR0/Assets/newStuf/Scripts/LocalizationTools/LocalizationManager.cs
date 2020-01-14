using System;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace LocalizationTools
{

    public class LocalizationManager : MonoBehaviour
    {
        


        public static LocalizationManager instance;

        private Dictionary<string,string> _localizedText;
        private bool _isReady = false;
        public bool isReady { get => _isReady;}

        private string _localisationIsMissingMessage = "Localisation Is Missing.";

        private void Awake() {
            if(instance == null){
                instance = this;
            }if(instance != this){
                Destroy(this);
            }

            DontDestroyOnLoad(this);
        }

        public void LoadLocalizedText(string filename){

            _localizedText = new Dictionary<string, string>();

            string filePath = Path.Combine(Application.streamingAssetsPath,filename);

            if(File.Exists(filePath)){

                string dataAsJson = File.ReadAllText(filePath);

                LocalizationData localizationDate = JsonUtility.FromJson<LocalizationData>(dataAsJson);

                foreach (LocalizationItem item in localizationDate.items)
                {
                    _localizedText.Add(item.key,item.value);
                }

                Debug.Log("Localisation data loaded. Dictionary contains : " + _localizedText.Count );

                if(OnLocalisedTextUpdated != null){
                    OnLocalisedTextUpdated();
                }

                _isReady = true;

                PlayerPrefs.SetString("Language",filename);

            }else{
                Debug.LogError("Cannot finde localisation file : " + filename +  " in : " + filePath);
                _isReady = false;
            }

        }

        public string GetLocalisedValue(string key){
           
            if(_localizedText.ContainsKey(key))
            {
                return _localizedText[key];
            }

            return _localisationIsMissingMessage;
        }

        public event Action OnLocalisedTextUpdated;

        
    }

}

