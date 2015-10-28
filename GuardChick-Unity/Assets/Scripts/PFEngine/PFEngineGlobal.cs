using UnityEngine;
using System.Collections;

public class PFEngineGlobal {
	public const float VERSION = 1.0f;
	public float cameraSize = 3.15f;

	public static Vector2 ScreenTopLeftPosition {
		get {
			return new Vector2(0, 0);
		}
	}

	public static Vector2 ScreenTopRightPosition {
		get {
			return new Vector2(0, 0);
		}
	}

}
