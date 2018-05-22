using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPick : MonoBehaviour {

    GameObject playerObject;
    
    //OnTriggerStay
    void OnTriggerStay(Collider PlayerPickCollider)
    {
        // Debug-draw all contact points and normals
        if (PlayerPickCollider.gameObject.GetComponent<objattr>().canpick)
        {
            //GameObject player = GameObject.FindGameObjectsWithTag("MobileMaleFreeSimpleMovement1")[0];
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("F");
                playerObject.GetComponent<playerController>().addBagList(PlayerPickCollider.gameObject); 
            }
        }
    }

    // Use this for initialization
    void Start () {
        playerObject = GameObject.Find("MobileMaleFreeSimpleMovement1");
	}
	
	// Update is called once per frame
	void Update () {

    }
}
