using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventSlot : MonoBehaviour
{
    private int randNum;
    // Start is called before the first frame update
    void Start()
    {
        randNum = Random.Range(0, 2);
        if(randNum == 1)
        {
            gameObject.GetComponent<Image>().color = Color.blue;
            gameObject.tag = "Event";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
