using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X01_CapsuleObject : APoolable {
	[SerializeField] Rigidbody rigidBody;
	private float Y_COORD_THRESHOLD = -1.17f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (this.transform.position.y <= Y_COORD_THRESHOLD && this.poolRef != null) {
			this.poolRef.ReleasePoolable (this);
		}
	}

	public override void Initialize() {
		Debug.Log ("Initialize");
	}

	public override void Release() {
		this.rigidBody.velocity = Vector3.zero;
	}

	public override void OnActivate() {
		
	}

}
