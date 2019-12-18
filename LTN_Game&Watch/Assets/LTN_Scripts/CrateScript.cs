using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateScript : MonoBehaviour
{
    private GameMasterManager gameManag;
    public GameObject crate;
    private bool timeCheck;

    // Start is called before the first frame update
    void Start()
    {
        gameManag = gameObject.GetComponent<GameMasterManager>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CrateMovCoroutine());
    }

    void CrateMovePos()
    {
        if (!timeCheck)
        {
            for (int i = 0; i < gameManag.cratePositions.Length; i++)
            {
                crate.transform.position = gameManag.cratePositions[i].transform.position;
            }
        }
    }

    IEnumerator CrateMovCoroutine()
    {
        yield return new WaitForSeconds(2);

        CrateMovePos();

        Debug.Log("Finished Crate Mov");
    }
}

/*Faire bouger les caisses et calculer leurs positions
 * Renvoyer le tout au game manager pour executer les fonctions de victoire ou de perte
 * Clear l'écran quand le camion est rempli*/
