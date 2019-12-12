using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MarioMov;
    public float LuigiMov;

    public Rigidbody2D MarioChara;
    public Rigidbody2D Luigichara;

    public GameObject [] MarioPos;
    public GameObject[] LuigiPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MarioMovement();
    }

    public void MarioMovement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MarioMov = Input.GetAxisRaw("Vertical");
            Vector2 mPos = new Vector2(transform.position.x, transform.position.y);
            
        }
    }

    public void LuigiMovement()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            LuigiMov = Input.GetAxisRaw("Vertical");
            Vector2 lPos = new Vector2(transform.position.x, transform.position.y);
        }
    }
}
/*Fait bouger Mario et Luigi
 renvoie ses infos au Game manager*/
