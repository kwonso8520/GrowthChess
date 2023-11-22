using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChessSlot : MonoBehaviour,IDropHandler
{
    private GameManager gm;
    private void Start()
    {
        gm = GameObject.FindAnyObjectByType<GameManager>();
    }
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DragSystem dragSystem = dropped.GetComponent<DragSystem>();
        dragSystem.endPos = transform.position;
        Vector2 movePos = dragSystem.endPos - dragSystem.startPos;
        if (dragSystem.chessWare == Shape.King)
        {
            if (Mathf.Abs((int)movePos.x) + Mathf.Abs((int)movePos.y) == gm.n * 135)
            {
                if (transform.childCount == 0)
                {
                    dropped = eventData.pointerDrag;
                    dragSystem = dropped.GetComponent<DragSystem>();
                    dragSystem.parentAfterDrag = transform;
                    gm.doDrop = true;
                }
                else if (eventData.pointerDrag.tag != transform.GetChild(0).gameObject.tag)
                {
                    Destroy(transform.GetChild(0).gameObject);
                    dropped = eventData.pointerDrag;
                    dragSystem = dropped.GetComponent<DragSystem>();
                    dragSystem.parentAfterDrag = transform;
                    gm.doDrop = true;
                }
                if (transform.tag == "Event")
                {
                    gm.n++;
                }
            }
        }
        else if (dragSystem.chessWare == Shape.Knight)
        {
            if ((Mathf.Abs((int)movePos.x) == 270 && Mathf.Abs((int)movePos.y) == 135) || (Mathf.Abs((int)movePos.x) == 135 && Mathf.Abs((int)movePos.y) == 270))
            {
                if (transform.childCount == 0)
                {
                    dropped = eventData.pointerDrag;
                    dragSystem = dropped.GetComponent<DragSystem>();
                    dragSystem.parentAfterDrag = transform;
                    gm.doDrop = true;
                }
                else if (eventData.pointerDrag.tag != transform.GetChild(0).gameObject.tag)
                {
                    Destroy(transform.GetChild(0).gameObject);
                    dropped = eventData.pointerDrag;
                    dragSystem = dropped.GetComponent<DragSystem>();
                    dragSystem.parentAfterDrag = transform;
                    gm.doDrop = true;
                }
            }
        }
        else if (dragSystem.chessWare == Shape.Bishop)
        {
            if ((Mathf.Abs((int)movePos.x) == Mathf.Abs((int)movePos.y)))
            {
                if (transform.childCount == 0)
                {
                    dropped = eventData.pointerDrag;
                    dragSystem = dropped.GetComponent<DragSystem>();
                    dragSystem.parentAfterDrag = transform;
                    gm.doDrop = true;
                }
                else if (eventData.pointerDrag.tag != transform.GetChild(0).gameObject.tag)
                {
                    Destroy(transform.GetChild(0).gameObject);
                    dropped = eventData.pointerDrag;
                    dragSystem = dropped.GetComponent<DragSystem>();
                    dragSystem.parentAfterDrag = transform;
                    gm.doDrop = true;
                }
            }
        }
        else
        {
            if ((Mathf.Abs((int)movePos.x) == 0 && Mathf.Abs((int)movePos.y) != 0) || (Mathf.Abs((int)movePos.x) != 0 && Mathf.Abs((int)movePos.y) == 0))
            {
                if (transform.childCount == 0)
                {
                    dropped = eventData.pointerDrag;
                    dragSystem = dropped.GetComponent<DragSystem>();
                    dragSystem.parentAfterDrag = transform;
                    gm.doDrop = true;
                }
                else if (eventData.pointerDrag.tag != transform.GetChild(0).gameObject.tag)
                {
                    Destroy(transform.GetChild(0).gameObject);
                    dropped = eventData.pointerDrag;
                    dragSystem = dropped.GetComponent<DragSystem>();
                    dragSystem.parentAfterDrag = transform;
                    gm.doDrop = true;
                }
            }

        }
    }  
}