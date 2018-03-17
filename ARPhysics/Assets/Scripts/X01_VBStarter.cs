using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class X01_VBStarter : ImageTargetBehaviour {
	[SerializeField] private GameObject virtualButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void OnTrackerUpdate(Status newStatus) {
		base.OnTrackerUpdate (newStatus);

		if (newStatus == Status.TRACKED) {
			this.virtualButton.SetActive (true);

//			VirtualButtonBehaviour vbb = this.CreateVirtualButton ("VB1", new Vector2(0, 0), new Vector2(0.2f, 0.2f));
//			vbb.RegisterEventHandler (this);
//			Debug.Log ("VB Added");
		}
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb) {
	
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb) {
	
	}
}
