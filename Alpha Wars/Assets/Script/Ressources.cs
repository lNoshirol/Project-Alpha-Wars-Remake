using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ressources : MonoBehaviour
{
    public static Ressources instance;

    public int Beton;
    public TextMeshProUGUI BetonTxt;
    public int Acier;
    public TextMeshProUGUI AcierTxt;
    public int Charbon;
    public TextMeshProUGUI CharbonTxt;
    public int Carburant;
    public TextMeshProUGUI CarburantTxt;

    private void Awake()
    {
        instance = this;
    }

    public void EditRessource(int identifiant, int _profit)
    {
        if (identifiant == 0)
        {
            Beton += _profit;
            if (Beton <= 0)
            {
                Beton = 0;
            }
            BetonTxt.text = Beton.ToString();
        }
        else if (identifiant == 1)
        {
            Acier += _profit;
            if (Acier <= 0)
            {
                Acier = 0;
            }
            AcierTxt.text = Acier.ToString();
        }
        else if (identifiant == 2)
        {
            Charbon += _profit;
            if (Charbon <= 0)
            {
                Charbon = 0;
            }
            CharbonTxt.text = Charbon.ToString();
        }
        else if (identifiant == 3)
        {
            Carburant += _profit;
            if (Carburant <= 0)
            {
                Carburant = 0;
            }
            CarburantTxt.text = Carburant.ToString();
        }
    }

    void Start()
    {
        EditRessource(0, 50);
    }
}