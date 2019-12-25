using System;
using UnityEngine;
using UnityEngine.UI;

namespace newStuf.Scripts
{
    public class MovingModule : MonoBehaviour
    {
        
        [SerializeField] private GameObject placementIndicator;
        private bool _isMoving;

        public bool IsMoving => _isMoving;

        private Transform objectToMove;
        private Vector3 previousPlace;
        

        public void StartMoving(GameObject selectedObj)
        {
            objectToMove = selectedObj.transform;
            previousPlace = objectToMove.transform.position;

            Move();
        }
        public void EndMoving()
        {
            if (_isMoving)
            {
                objectToMove.SetParent(null);
                _isMoving = false;
            }
        }

        public void RevertMoving()
        {
            if (_isMoving)
            {
                EndMoving();
                objectToMove.position = previousPlace;
                _isMoving = false;
            }
        }

        private void Move()
        {
            objectToMove.SetParent(placementIndicator.transform);
            objectToMove.localPosition = Vector3.zero;
            _isMoving = true;
        }

    }
}