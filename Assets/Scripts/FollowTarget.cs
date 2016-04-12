using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour {

	public Transform playerTransform;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - playerTransform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = playerTransform.position + offset;
	}
}
