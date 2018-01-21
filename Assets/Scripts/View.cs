using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour {

    public GameObject obj;

	// Use this for initialization
	void Start () {
        obj.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Show()
    {
        obj.SetActive(true);
    }

    public void PointerClick()
    {
        GameObject view = GameObject.FindWithTag("View");

        obj.SetActive(true);
        Destroy(this, .1f);
        GameObject player = GameObject.FindWithTag("Player");
        player.transform.position = transform.position;
        GameObject teleport = GameObject.FindWithTag("Teleport");
        Destroy(teleport, .1f);
    }
}
