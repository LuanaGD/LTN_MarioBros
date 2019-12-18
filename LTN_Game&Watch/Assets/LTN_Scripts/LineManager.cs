using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineManager : MonoBehaviour
{
    public int lineID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject bodySprite = this.gameObject.transform.GetChild(0).gameObject;
            GameObject baseArmSprite = this.gameObject.transform.GetChild(1).gameObject;

            bodySprite.SetActive(true);
            baseArmSprite.SetActive(true);            
        }
    }
}
