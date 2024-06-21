using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculeStat : MonoBehaviour
{
    [Header("Move parameter")]
    [SerializeField] private float _speed;

    [Header("Def stat")]
    [SerializeField] private float _armor;

    [Header("Fight stats")]
    [SerializeField] private float _normalPower;
    [SerializeField] private float _antiAirPower;
    [SerializeField] private float _antiGroundPower;
    [SerializeField] private float _antiBasePower;
}
