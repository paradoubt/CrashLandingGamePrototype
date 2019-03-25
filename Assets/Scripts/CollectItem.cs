using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : MonoBehaviour {
    public static int items = 0;
	// Use this for initialization
	void Awake () {
        items++;
	}

	// Update is called once per frame
    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
            items--;
        gameObject.SetActive(false);
    }
}
