using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class ClickManager : MonoBehaviour
{
    private VehiculeCountManager vehiculeCountManager;

    private void Start()
    {
        vehiculeCountManager = VehiculeCountManager.instance;
    }

    public void OnLeftClick(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            Physics.Raycast(ray, out hitInfo);

            GameObject _objectHit = hitInfo.collider.gameObject;

            if (_objectHit.CompareTag("TONK"))
            {
                if (!vehiculeCountManager.SelectedTroopsList.Contains(_objectHit))
                {
                    vehiculeCountManager.AddTroopInList(_objectHit);
                    _objectHit.GetComponent<VehiculeController>().SelecteVehicule();
                }
                else
                {
                    vehiculeCountManager.RemoveTroopInList(_objectHit);
                    _objectHit.GetComponent<VehiculeController>().UnSelecteVehicule();
                }
            }
            else if (_objectHit.CompareTag("Ground"))
            {
                foreach(GameObject vehicule in vehiculeCountManager.SelectedTroopsList)
                {
                    vehicule.GetComponent<NavMeshAgent>().SetDestination(hitInfo.point);
                }
            }
        }
    }
}