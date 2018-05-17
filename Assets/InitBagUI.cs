using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class InitBagUI : MonoBehaviour {

    int bagsize = 10;
	// Use this for initialization
	void Start () {

        GameObject ItemUI = GameObject.Find("ItemPanel");
        ItemUI.GetComponent<RectTransform>().anchorMax = new Vector2(0.9f, 0.9f);
        ItemUI.GetComponent<RectTransform>().anchorMin = new Vector2(0.1f, 0.1f);
        ItemUI.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 0);

        for (int a = 0;a < bagsize; a++)
        {
            GameObject b = new GameObject("myimg" + a, typeof(Image));
            b.GetComponent<Image>().raycastTarget = false;
            //b.transform.SetParent(Selection.activeTransform);
            //Selection.activeGameObject = b;
            b.transform.SetParent(GameObject.Find("ItemPanel").transform);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
