using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applescript : MonoBehaviour {

    //public bool canpick = true;

	// Use this for initialization
	void Start () {
        this.gameObject.AddComponent<objattr>();
        this.gameObject.GetComponent<objattr>().canpick = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
