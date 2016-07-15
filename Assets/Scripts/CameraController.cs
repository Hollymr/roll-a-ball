using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;


	// Use this for initialization
	void Start () {
        // camera position - player position
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        // player position + offset to = camera position
        transform.position = player.transform.position + offset;
	
	}
}
