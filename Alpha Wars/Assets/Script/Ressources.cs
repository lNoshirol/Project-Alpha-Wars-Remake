using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ressources : MonoBehaviour
{
    public static Ressources instance;
    public int Charbon;
    public int Carburant;
    public int Beton;
    public int Acier;
    public TextMeshProUGUI CharbonTxt;
    public TextMeshProUGUI CarburantTxt;
    public TextMeshProUGUI BetonTxt;
    public TextMeshProUGUI AcierTxt;

    private void Awake()
    {
        instance = this;
    }
    public void EditRessource(int identifiant, int _profit)
    {
        if (identifiant == 0)
        {
            Charbon += _profit;
            if (Charbon <= 0)
            {
                Charbon = 0;
            }
            CharbonTxt.text = Charbon.ToString();
        }
        else if (identifiant == 1)
        {
            Carburant += _profit;
            if (Carburant <= 0)
            {
                Carburant = 0;
            }
            CarburantTxt.text = Carburant.ToString();
        }
        else if (identifiant == 2)
        {
            Beton += _profit;
            if (Beton <= 0)
            {
                Beton = 0;
            }
            BetonTxt.text = Beton.ToString();
        }
        else if (identifiant == 3)
        {
            Acier += _profit;
            if (Acier <= 0)
            {
                Acier = 0;
            }
            AcierTxt.text = Acier.ToString();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        EditRessource(0, 50);
    }
}
