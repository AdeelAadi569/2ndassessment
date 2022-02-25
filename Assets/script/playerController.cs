using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public float speed,sensitiivity=3;
    private Rigidbody playerrb;
    public Vector2 turn;
    public GameObject aroowimage;
    public GameObject player,bullet;
    public float bulletspeed=10;
    public Material playermaterial;
    private bool color;
    public float coun;
    private uprenemy enemyupr;
    public Text countertext;
    // Start is called before the first frame update
    void Start()
    {
        countertext.text="Score"+coun;
        playerrb=GetComponent<Rigidbody>();
        enemyupr=GameObject.Find("uprenemy").GetComponent<uprenemy>();
       // aroowimage.transform.position=player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        coun=coun+enemyupr.counter;
        countertext.text="Score :"+coun;

        //turn.x+=Input.GetAxis("Mouse X")*sensitiivity;
        turn.y+=Input.GetAxis("Mouse Y")*sensitiivity;
        transform.localRotation=Quaternion.Euler(0,-turn.y,0);
        var horizontal=Input.GetAxis("Horizontal");
        var vertica=Input.GetAxis("Vertical");
        playerrb.AddForce(Vector3.forward*speed*vertica,ForceMode.Impulse);
        playerrb.AddForce(Vector3.right*speed*horizontal,ForceMode.Impulse);
        if (Input.GetKeyDown(KeyCode.Space))
        {
           GameObject bulletspawn= Instantiate(bullet,new Vector3(transform.position.x,transform.position.y,transform.position.z+1),player.transform.rotation);
           Rigidbody bulletrb=bulletspawn.GetComponent<Rigidbody>();
           bulletrb.AddForce(Vector3.forward*bulletspeed);
           
        }
        if(transform.position.y<=-1){
            Destroy(gameObject);
            Time.timeScale=0;
        }
        if(color==true){
           GetComponent<MeshRenderer>().material=playermaterial;
           color=false;
        }
        
    }
    public void OnCollisionEnter(Collision col){
        if(col.gameObject.tag=="enemy"){
            color=true;
             
        }
    }
}
