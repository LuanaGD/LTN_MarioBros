using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMasterManager : MonoBehaviour
{
    public Transform[] cratePositions;
    public GameObject[] cratePosition;
    public GameObject[] truckLoad;
    public GameObject crate;
    private CrateScript spawnedCrate;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CrateSpawnCoroutine());
    }

    IEnumerator CrateSpawnCoroutine() //instantiate the crates : OK
    {
        while(truckLoad.Length < 9)
        {
            cratePosition[2].gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
            Debug.Log("coroutine over");
        }

        /*for (int i = 0; i < cratePositions.Length; i++)
        {
            /*Instantiate(crate);
            crate.transform.position = cratePositions[0].transform.position;
            Debug.Log("crate exist");

            cratePosition[2].gameObject.SetActive(true);
            yield return new WaitForSeconds(4);
            Debug.Log("coroutine over");
        }*/
            
    }

}

/*fontion de win et lose
 supervise les positions des caisses
 envoie les fonctions de win et lose
 s'assure que Mario et Luigi se trouvent sur la bonne rangée
 */
