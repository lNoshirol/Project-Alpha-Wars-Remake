using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculeStat : MonoBehaviour
{
    //[Header("Move parameter")]
    [field : SerializeField] public float _speed { get; private set; }

    //[Header("Def stat")]
    [field: SerializeField] public float _armor { get; private set; }

    //[Header("Fight stats")]
    [field: SerializeField] public float _normalPower { get; private set; }
    [field: SerializeField] public float _antiAirPower { get; private set; }
    [field: SerializeField] public float _antiGroundPower { get; private set; }
    [field: SerializeField] public float _antiBasePower {  get; private set; }
}
