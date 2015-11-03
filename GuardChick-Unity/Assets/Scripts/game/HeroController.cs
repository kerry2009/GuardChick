using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour {
	public SkeletonAnimation avatar;
	public BoxCollider2D attackArea;

	private int CURRENT_STATE = 0;
	private HeroProperties properties;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
