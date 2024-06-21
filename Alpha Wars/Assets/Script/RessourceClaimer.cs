using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RessourceClaimer : MonoBehaviour
{
    public IEnumerator ATTENDBeton(int countdown)
    {
        yield return new WaitForSeconds(countdown);
        Ressources.instance.EditRessource(0, countdown * 100);
    }
    public IEnumerator ATTENDAcier(int countdown)
    {
        yield return new WaitForSeconds(countdown);
        Ressources.instance.EditRessource(1, countdown * 100);
    }
    public IEnumerator ATTENDCharbon(int countdown)
    {
        yield return new WaitForSeconds(countdown);
        Ressources.instance.EditRessource(2, countdown * 100);
    }
    public IEnumerator ATTENDCarburant(int countdown)
    {
        yield return new WaitForSeconds(countdown);
        Ressources.instance.EditRessource(3, countdown * 100);
    }
 }
