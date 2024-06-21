using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VehiculeController : MonoBehaviour
{
    [SerializeField] private GameObject _selectedImage;
    [field : SerializeField] public bool IsSelected {  get; private set; }
    private NavMeshAgent _navMeshAgent;
    private VehiculeStat _vehiculeStats;

    [SerializeField] private Vector3 _destination;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _vehiculeStats = GetComponent<VehiculeStat>();

        _navMeshAgent.speed = _vehiculeStats._speed;
    }

    public void SetDestination(Vector3 posToGo)
    {
        _destination = posToGo;
        _navMeshAgent.SetDestination(_destination);
    }

    public void SelecteVehicule()
    {
        IsSelected = true;
        _selectedImage.SetActive(true);
    }

    public void UnSelecteVehicule()
    {
        IsSelected = false;
        _selectedImage.SetActive(false);
    }
}
