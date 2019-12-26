using System;
using UnityEngine;

namespace newStuf.Scripts
{
    public class Selectable : MonoBehaviour
    {
        [SerializeField] private GameObject selectedIndicator;

        private void Start()
        {
            selectedIndicator.SetActive(false);
        }

        public void Selected()
        {
            if (selectedIndicator != null)
                selectedIndicator.SetActive(true);
        }

        public void Deselected()
        {
            if (selectedIndicator != null)
                selectedIndicator.SetActive(false);
        }

    }
}
    