using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnUnit : MonoBehaviour
{
    public GameObject VehiculePrefab;
    public GameObject SpawnPoint;
    public void OnClick()
    {
        GameObject Vehicule = Instantiate(VehiculePrefab);
        Vehicule.transform.localPosition = SpawnPoint.transform.localPosition;
    }
}