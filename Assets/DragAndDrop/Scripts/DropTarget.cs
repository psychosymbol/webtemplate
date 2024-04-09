using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DropTarget : MonoBehaviour, IDropHandler
{
    public Target dropTarget;
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropObject = eventData.pointerDrag;
        DragableObject dragableObject = dropObject.GetComponent<DragableObject>();
        if (dragableObject.dragableTarget == dropTarget)
        {
            dragableObject.parentAfterDrag = transform;
        }
    }
}
