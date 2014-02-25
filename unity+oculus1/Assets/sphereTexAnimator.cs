using UnityEngine;
using System.Collections;

public class sphereTexAnimator : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		 
		Vector2 offset = new Vector2 (0,Time.timeSinceLevelLoad);
		renderer.material.SetTextureOffset ("_MainTex", offset);
//		gameObject.renderer.normalMap.offset.x = time;
//		time;
	}
}
