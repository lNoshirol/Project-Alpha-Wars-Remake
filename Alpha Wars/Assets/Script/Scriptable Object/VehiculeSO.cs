using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Vehicule", menuName = "VEH", order = 1)]
public class VehiculeSO : ScriptableObject
{
    public float _speed;
    public int _HP;
    public int _HPMax;
    public int _firePower;
}
