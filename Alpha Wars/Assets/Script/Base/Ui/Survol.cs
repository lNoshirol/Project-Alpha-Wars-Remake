using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Survol : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField]
    private GameObject panel;

    public void OnPointerEnter(PointerEventData eventData)
    {
        StopAllCoroutines();
        StartCoroutine(panelOn());
    }

    IEnumerator panelOn()
    {
        yield return new WaitForSeconds(0.5f);
        panel.SetActive(true);
    }
}