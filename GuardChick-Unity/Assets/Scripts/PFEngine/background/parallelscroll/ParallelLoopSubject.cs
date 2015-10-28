using UnityEngine;
using System.Collections;
using PFEngine.background;

namespace PFEngine.background.parallelscroll {
	public class ParallelLoopSubject : BackGroundSetting {
		private float offsetX = 0f;

		public void CalculateOffsetPosition (float startPointX) {
			offsetX = transform.position.x - startPointX;
		}

		private static Vector2 vect2;
		public void MoveX (float moveSpeedX) {
			vect2 = transform.position;

			vect2.x += moveSpeedX;
			transform.position = vect2;
		}

		public void TransportToEndPointX (float endPointX) {
			vect2 = transform.position;
			
			vect2.x = endPointX + offsetX;
			transform.position = vect2;
		}

	}
}