using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

	public Vector3 lastValidPos ;

	public Text FWT1;
	public Text FWT2;

	public GameObject camera;


    void Start ()
    {
        rb = GetComponent<Rigidbody>();

        lastValidPos=transform.position;
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }

    void Update()
    {
    	if (Input.GetKeyDown("escape")){
    		if (camera.transform.position.y>=200){
				FWT1.text="Welcome to the free world?";
				FWT2.text="Welcome to the free world?";
    		}
    	}
		if (Input.GetKeyUp("escape")){
		Application.Quit();
		}

		if (transform.position.x<=94.5 && transform.position.x >=-94.5 && transform.position.z <=94.5 && transform.position.z>=-94.5){
				lastValidPos=transform.position;
			}else{
				transform.position=lastValidPos;
				}
    }
}