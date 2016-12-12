using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour {

	public GameObject player;

	public float flySpeed;

	public float finalHeight=200;

	private bool wentOutside= false;
	private bool reachedHeight = false;


	void LateUpdate () {
		if (!wentOutside){
			if (player.transform.position.x>=11 || player.transform.position.x<=-11 || player.transform.position.z>=11 || player.transform.position.z <= -11f){
			wentOutside=true;
			}
		}else if (!reachedHeight){
			if (this.transform.position.y<finalHeight){
				float temp = this.transform.position.y;
				transform.position=new Vector3(0,temp+flySpeed,0);
			}else{
			reachedHeight = true;
			}
		}


	}
}
