using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMotion : MonoBehaviour {

    public float Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        this.transform.Translate(Vector3.forward*Speed);
        
	}

    void OnCollisionEnter(Collision collision) {
        Debug.Log("Collision between two colliders");

        GameObject.Destroy(this.gameObject);

        GameObject.Destroy(collision.collider.gameObject);
    }
}
