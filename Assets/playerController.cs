using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    //bagUI
    bool bagUIisShow = false;
    GameObject bagUIObject;
    List<GameObject> bagObjectList = new List<GameObject>();

    //addObject into bagList
    public void addBagList(GameObject addBagObject)
    {
        bagObjectList.Add(addBagObject);
        addBagObject.SetActive(false);
        Debug.Log("add");
    }

	// Use this for initialization
	void Start () {
        //bagUI init
        bagUIObject = GameObject.Find("BagUI");
        bagUIObject.SetActive(bagUIisShow);
    }
	
	// Update is called once per frame
	void Update () {

        //bagUIcontrol
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B");
            if (bagUIisShow == false)
            {
                bagUIisShow = true;
            }
            else
            {
                bagUIisShow = false;
            }
            bagUIObject.SetActive(bagUIisShow);
        }
    }
}
