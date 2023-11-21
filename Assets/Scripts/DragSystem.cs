using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragSystem : MonoBehaviour,IDragHandler,IBeginDragHandler,IEndDragHandler
{
    public Image iamge;
    public Transform startPos;
    public Transform endPos;
    [HideInInspector]
    public Transform parentAfterDrag;
    private GameManager gm;
    public Shape chessWare;

    private void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }
    private void Update()
    {
          
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (gm.player1Turn)
        {
            if (eventData.pointerDrag.tag == "Player")
            {
                startPos = eventData.pointerDrag.transform;
                parentAfterDrag = transform.parent;
                transform.SetParent(transform.root);
                transform.SetAsLastSibling();
                iamge.raycastTarget = false;
            }
        }
        else
        {
            if (eventData.pointerDrag.tag == "Player2")
            { 
                startPos = eventData.pointerDrag.transform;
                parentAfterDrag = transform.parent;
                transform.SetParent(transform.root);
                transform.SetAsLastSibling();
                iamge.raycastTarget = false;
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (gm.player1Turn)
        {
            if (eventData.pointerDrag.tag == "Player")
            {
                transform.position = Input.mousePosition;
            }
        }
        else
        {
            if (eventData.pointerDrag.tag == "Player2")
            {
                transform.position = Input.mousePosition;
            }
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (gm.player1Turn)
        {
            if (eventData.pointerDrag.tag == "Player")
            {
                transform.SetParent(parentAfterDrag);
                iamge.raycastTarget = true;
                if(gm.doDrop)
                {
                    gm.doDrop = false;
                    gm.player1Turn = false;
                }
            }
        }
        else
        {
            if (eventData.pointerDrag.tag == "Player2")
            {
                transform.SetParent(parentAfterDrag);
                iamge.raycastTarget = true;
                if (gm.doDrop)
                {
                    gm.doDrop = false;
                    gm.player1Turn = true;
                }
            }
        }
    }
}