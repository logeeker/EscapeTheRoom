using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text escapeText;
	public Text freeWorldText1;
	public Text freeWorldText2;

	public GameObject player;

	public GameObject camera;

	private Vector3 iniPos;
	private bool hasDisplayed=false;
	private bool hasReachedHeight;

	// Use this for initialization
	void Start () {
		iniPos=player.transform.position;
		freeWorldText1.text=" ";
		freeWorldText2.text=" ";
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (!hasDisplayed){
			if (!player.transform.position.Equals(iniPos)){
				escapeText.text=" ";
				hasDisplayed=true;
			}
		}else{
			if (!hasReachedHeight){
				if (camera.transform.position.y>=200){
					hasReachedHeight=true;
					freeWorldText1.text="Welcome to the free world!";
					freeWorldText2.text="Welcome to the free world!";
				}
			}
		}
		
		
	}
}
