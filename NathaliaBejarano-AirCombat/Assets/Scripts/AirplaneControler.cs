using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneControler : MonoBehaviour {
    public float Speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKey(KeyCode.UpArrow)) {
            this.transform.Translate(Vector3.up*Speed);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            this.transform.Translate(Vector3.down*Speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            this.transform.Translate(Vector3.left*Speed);
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            this.transform.Translate(Vector3.right*Speed);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {

            //creamos game object a partir de un prefab (planos de un edificio)
            GameObject newMissile = GameObject.Instantiate(Resources.Load("Bullets/Missile") as GameObject);

            GameObject shootPivot = GameObject.Find("Avión/ShootPivot");

            newMissile.transform.SetParent(shootPivot.transform);

            newMissile.transform.localPosition = Vector3.zero;

            newMissile.transform.SetParent(null);
        }



    }
}
