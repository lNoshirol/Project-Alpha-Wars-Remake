using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculeCountManager : MonoBehaviour
{
    public static VehiculeCountManager instance;

    [field : SerializeField] public List<GameObject> SelectedTroopsList { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    public void AddTroopInList(GameObject obj)
    {
        SelectedTroopsList.Add(obj);
    }

    public void RemoveTroopInList(GameObject obj)
    {
        SelectedTroopsList.Remove(obj);
    }
}