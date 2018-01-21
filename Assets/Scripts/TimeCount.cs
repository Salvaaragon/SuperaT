using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCount : MonoBehaviour {

    private float timer = 0f;

	// Use this for initialization
	void Start () {
        timer = 0f;
    }
	
	// Update is called once per frame
	void Update () {
        timer += 1 * Time.deltaTime;
	}
}
