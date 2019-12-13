using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMov : MonoBehaviour
{
    public Transform[] MarioPos;
    public GameObject MarioChara;
    private int currentPos = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MarioMovement();
    }

    private void MarioMovement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentPos++;
            MarioChara.transform.position = MarioPos[currentPos].transform.position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentPos -= 1;
            MarioChara.transform.position = MarioPos[currentPos].transform.position;
        }
    }
}
