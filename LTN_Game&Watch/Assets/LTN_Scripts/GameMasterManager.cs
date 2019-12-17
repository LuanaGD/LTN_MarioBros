using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMasterManager : MonoBehaviour
{
    public Transform[] cratePositions;
    public GameObject crate;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CrateSpawnCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CrateSpawnCoroutine()
    {
        Instantiate(crate);
        Debug.Log("crate exist");
        
        yield return new WaitForSeconds(5);
        Debug.Log("coroutine over");
    }

}

/*fontion de win et lose
 supervise les positions des caisses
 envoie les fonctions de win et lose
 s'assure que Mario et Luigi se trouvent sur la bonne rangée
 */
