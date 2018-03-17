﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class X01_StepScreen : MonoBehaviour {

	[SerializeField] private Text displayText;
	private bool firstScanSuccess = false;
	private bool finalScanSuccess = false;

	// Use this for initialization
	void Start () {
		EventBroadcaster.Instance.AddObserver (EventNames.X01_Events.ON_FIRST_SCAN, this.OnFirstScan);
		EventBroadcaster.Instance.AddObserver (EventNames.X01_Events.ON_FINAL_SCAN, this.OnFinalScan);
	}

	void OnDestroy() {
		EventBroadcaster.Instance.RemoveObserver (EventNames.X01_Events.ON_FIRST_SCAN);
		EventBroadcaster.Instance.RemoveObserver (EventNames.X01_Events.ON_FINAL_SCAN);
	}

	// Update is called once per frame
	void Update () {
		
	}

	private void OnFirstScan() {
		if (!this.firstScanSuccess) {
			this.displayText.text = "Success! Scan the second target!";
			this.firstScanSuccess = true;
		}
	}

	private void OnFinalScan() {
		if (!this.finalScanSuccess) {
			this.displayText.text = "There are x objects falling!";
			this.finalScanSuccess = true;
		}
	}
}
