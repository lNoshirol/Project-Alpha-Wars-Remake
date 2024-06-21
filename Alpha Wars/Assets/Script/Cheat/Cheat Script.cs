using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Ressources.instance.EditRessource(0, 5000);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Ressources.instance.EditRessource(1, 5000);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ressources.instance.EditRessource(2, 5000);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Ressources.instance.EditRessource(3, 5000);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.Q))
            {
                Ressources.instance.EditRessource(0, 5000);
            }
            if (Input.GetKey(KeyCode.W))
            {
                Ressources.instance.EditRessource(1, 5000);
            }
            if (Input.GetKey(KeyCode.E))
            {
                Ressources.instance.EditRessource(2, 5000);
            }
            if (Input.GetKey(KeyCode.R))
            {
                Ressources.instance.EditRessource(3, 5000);
            }
        }
    }
}