using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateScript : MonoBehaviour
{
    //public Transform[] cratePositions;
    private GameMasterManager crateItem;
    private GameMasterManager gameManag;
    private int cratePos = 0;
    private bool crateTravelFinish = false;
    //private bool timeCheck;

    // Start is called before the first frame update
    void Start()
    {
        gameManag = transform.GetComponent<GameMasterManager>();
        crateItem = GetComponent<GameMasterManager>();
        StartCoroutine(CrateMovCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /*IEnumerator CrateSpawnCoroutine()
    {
        for (int i = 0; i < gameManag.cratePositions.Length; i++)
        {
            Instantiate(crateItem.crate);
            Debug.Log("crate exist");


            /*crate.transform.position = gameManag.cratePositions[i].transform.position;
            Debug.Log("crate moved");

            yield return new WaitForSeconds(3);
            Debug.Log("coroutine over");
        }
    }*/


    IEnumerator CrateMovCoroutine() //move crate every x seconds
    {
        /*for (int i = 0; i < gameManag.cratePositions.Length; i++)
        {
            gameObject.transform.position = gameManag.cratePositions[i].transform.position;
        }*/

        while(!crateTravelFinish)
        {
            if(cratePos != 43)
            {
                cratePos++;
                this.gameObject.transform.position = gameManag.cratePositions[cratePos].transform.position;
                yield return new WaitForSeconds(2);
                Debug.Log("Finished Crate Mov");
            }
            if(cratePos == 43)
            {
                crateTravelFinish = true;
                Debug.Log("Finished Moving crate");
            }
        }

        

    }

}    

/*Faire bouger les caisses et calculer leurs positions
 * Renvoyer le tout au game manager pour executer les fonctions de victoire ou de perte
 * Clear l'écran quand le camion est rempli*/
