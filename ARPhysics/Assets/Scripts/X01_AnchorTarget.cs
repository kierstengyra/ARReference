using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class X01_AnchorTarget : ImageTargetBehaviour {

	[SerializeField] private GameObject stepUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void OnTrackerUpdate(Status newStatus) {
		base.OnTrackerUpdate (newStatus);

		if (newStatus == Status.TRACKED) {
			this.stepUI.SetActive (false);
		}
	}
}
