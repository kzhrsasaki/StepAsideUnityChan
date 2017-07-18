using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour {

	//unitychanの定義
	private GameObject unitychan;

	// Use this for initialization
	void Start () {
		this.unitychan = GameObject.Find ("unitychan");
	}
	
	// Update is called once per frame
    void Update () {

	      //Debug.Log(string.Format("{0} {1}", transform.position.z, unitychan.transform.position.z));
	      if (transform.position.z <= unitychan.transform.position.z - 4.0f) {
		      Debug.Log ("item destroyed.");
		      Destroy (this.gameObject);
	      }
		
	}
}
