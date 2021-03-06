﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour {

    public ButtonControl.ButtonType bt;

    public ButtonControl() { }

    private void OnMouseDown()
    {
        transform.localScale = new Vector3(0.48f, 0.48f);
    }

    private void OnMouseUp()
    {
        transform.localScale = new Vector3(0.5f, 0.5f);
        if(bt == ButtonControl.ButtonType.btnPlay)
        {
            Application.LoadLevel("levelScreen");
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public enum ButtonType
    {
        btnPlay
    }
}
