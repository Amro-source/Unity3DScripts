using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTurtle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }


        if (Input.GetKeyDown("space"))
        {
            transform.Translate(Vector3.up * 260 * Time.deltaTime, Space.World);
        }
    }
}
