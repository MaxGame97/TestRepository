using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0.0f, Input.GetAxis("Vertical") * Time.deltaTime, 0.0f));
	}
}
