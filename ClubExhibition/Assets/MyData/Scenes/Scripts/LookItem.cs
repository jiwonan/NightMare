using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LookItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IGvrPointerHoverHandler
{
    public GameObject walkSound; //이거

    public void OnLookItemBox(bool isLookAt)
    {
        Debug.Log(isLookAt);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        MoveCtrl.isStopped = true;
        walkSound.SetActive(false); //이거
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        MoveCtrl.isStopped = false;
        walkSound.SetActive(true); //이거
    }

    public void OnGvrPointerHover(PointerEventData eventData)
    {
        Debug.Log("Pointer Hover !!");
    }
}