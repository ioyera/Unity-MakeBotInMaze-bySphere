using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScrip : MonoBehaviour {
	public int points = 0;
	public float timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
	}
	private void OnGUI()
	{
		GUI.Label (new Rect(30, 30, 200, 50), "Score: " + points);
		GUI.Label (new Rect(230, 30, 200, 50), "Timer: " + timer);

	}
	private void OnTriggerEnter(Collider other)
	{
		Time.timeScale = 0.0f;

	}

}
