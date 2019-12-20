using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateScript : MonoBehaviour
{
    //public Transform[] cratePositions;
    private GameMasterManager gameManag;

    //private int cratePos = 0;
    //private float mRow1 = -0.65f;
    //private float lRow1 = -1.32f;
    //private bool crateTravelFinish = false;

    //private Vector2 nextPosition;
    //public GameObject crate;

    //private bool timeCheck;

    // Start is called before the first frame update
    void Start()
    {
        gameManag = transform.GetComponent<GameMasterManager>();
        //crateItem = GetComponent<GameMasterManager>();
        StartCoroutine(CrateMovCoroutine());
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


    IEnumerator CrateMovCoroutine() //move crate (this game object) every x seconds
    {
        for (int i = 2; i <= gameManag.cratePositions.Length; i++)
        {
            yield return new WaitForSeconds(1);
            gameManag.cratePosition[i-1].gameObject.SetActive(false);
            gameManag.cratePosition[i].gameObject.SetActive(true); //works. BUT only ONE crate moves
            Debug.Log("crate moved");
            Debug.Log("move done");
        }

       /* for (int i = 0; i < gameManag.cratePositions.Length ; i++)
        {
            Instantiate(crate);
            crate.transform.position = gameManag.cratePositions[0].transform.position;
            Debug.Log("crate exist");

            yield return new WaitForSeconds(3);
            Debug.Log("coroutine over");
        }*/

        /*while(!crateTravelFinish)
        {
            if(cratePos != 43)
            {
                cratePos++;
                crate.transform.position = gameManag.cratePositions[cratePos].transform.position;


                yield return new WaitForSeconds(2);
                Debug.Log("Finished Crate Mov");
            }
            else if(cratePos == 43)
            {
                crateTravelFinish = true;
                Debug.Log("Finished Moving crate");
            }
        }*/

        

    }

}    

/*Faire bouger les caisses et calculer leurs positions
 * Renvoyer le tout au game manager pour executer les fonctions de victoire ou de perte
 * Clear l'écran quand le camion est rempli*/
