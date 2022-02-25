using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject prefabenemyupr;
    public GameObject [] enemyspawnposupr;
    
    public GameObject prefabenemybtm;
    public GameObject [] enemyspawnposbtm;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy",1,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnEnemy(){
       for (int i = 0; i < enemyspawnposupr.Length; i++)
       {
           Instantiate(prefabenemyupr,enemyspawnposupr[i].transform.position,prefabenemyupr.transform.rotation);
       }
       for (int j = 0; j < enemyspawnposbtm.Length; j++)
       {
           Instantiate(prefabenemybtm,enemyspawnposbtm[j].transform.position,prefabenemybtm.transform.rotation);
       }
        
    }
}
