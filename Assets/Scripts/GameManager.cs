using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Shape
{
    King,
    Knight,
    Bishop,
    Rook
}
public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public bool player1Turn = true;
    public int n = 1;
    public bool doDrop = false;
    // Start is called before the first frame update
    void Start()
    {
        if (gameManager == null)
        {
            gameManager = this;
        }
        else
        {
            Destroy(gameObject);
        }
        player1Turn = true;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}