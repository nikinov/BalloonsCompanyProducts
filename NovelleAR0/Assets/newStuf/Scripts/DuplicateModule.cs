using UnityEngine;


public class DuplicateModule : MonoBehaviour
{

    private bool _isDuplicating = false;
    public bool IsDuplicating => _isDuplicating;

    [SerializeField] private Transform placementIndicator;

    private GameObject duplicatedObj;
    
    public void StartDuplicating(GameObject selectedObj)
    {
        duplicatedObj = Instantiate(selectedObj, placementIndicator.position,placementIndicator.rotation);
        _isDuplicating = true;
        duplicatedObj.transform.parent = placementIndicator;
    }

    public void EndDuplicating()
    {
        duplicatedObj.transform.parent = null;
        _isDuplicating = false;
    }

}