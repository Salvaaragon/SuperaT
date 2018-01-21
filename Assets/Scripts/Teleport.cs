using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PointerClick()
    {
        GameObject player = GameObject.FindWithTag("Player");
        player.transform.position = transform.position;
    }
}
