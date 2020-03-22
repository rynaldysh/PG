using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour
{
	public int speed=10;
	public Rigidbody2D sesuatu;
    // Start is called before the first frame update
    void Start()
    {
        sesuatu.velocity = new Vector2(-1,-1) *speed;
    }

    // Update is called once per frame
    void Update()
    {
       
}
 void OnCollisionEnter2D(Collision2D other){
    	if(other.collider.name=="kanan" || other.collider.name=="kiri"){
    		GetComponent<Transform>().position = new Vector2(0,0);
    	}
    }
}