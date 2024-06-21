using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Survol2 : MonoBehaviour, IPointerExitHandler
{
    [SerializeField] private GameObject panel;

    public void OnPointerExit(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(panelOff());
    }
    IEnumerator panelOff()
    {
        yield return new WaitForSeconds(0.1f);
        panel.SetActive(false);
    }
}
