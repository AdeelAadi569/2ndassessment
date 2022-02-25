using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uprenemy : MonoBehaviour
{
    private float speed=8;
    private GameObject player;
    private Rigidbody enemyrbupr;
    public float counter;
    private bool forwardmove;
    // Start is called before the first frame update
    void Start()
    {
        forwardmove=true;
        player=GameObject.Find("player");
        enemyrbupr=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(forwardmove==true){
            transform.Translate(Vector3.back*speed*Time.deltaTime);
        }
        if(forwardmove==false){
            enemyrbupr.AddForce(player.transform.position-transform.position*speed);
        }
        if(transform.position.y<=-1){
            Destroy(gameObject);
            counter=25;
        }
    }
    public void OnTriggerEnter(Collider col){
        if(col.gameObject.tag=="detection"){
            forwardmove=false;
            Debug.Log("collision detect");
           
        }
    }
}
