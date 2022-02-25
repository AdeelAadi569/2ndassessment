using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    private float speed=10;
    private playerController plyrcntrol;
    // Start is called before the first frame update
    void Start()
    {
        plyrcntrol=GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
      //  transform.Translate(plyrcntrol.transform.forward*speed*Time.deltaTime);
    }
}
