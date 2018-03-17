using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class X01_VirtualButtonHandler : MonoBehaviour, IVirtualButtonEventHandler {
	[SerializeField] private GameObject objectGroup;
	[SerializeField] private VirtualButtonBehaviour button;

	// Use this for initialization
	void Start () {
		this.button.RegisterEventHandler (this);
		Debug.Log ("Started.");
	}

	// Update is called once per frame
	void Update () {
//		Debug.Log ("Updated.");
	}

	private void Toggle() {
		Debug.Log ("Pressed Again");
		this.objectGroup.SetActive (true);

	}

	public void OnButtonPressed (VirtualButtonBehaviour vb) {
		Debug.Log ("Pressed");
		this.Toggle ();
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb) {

	}

}
