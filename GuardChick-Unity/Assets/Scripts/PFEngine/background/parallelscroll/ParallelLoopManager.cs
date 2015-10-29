using UnityEngine;
using System.Collections;
using PFEngine.background.parallelscroll;

namespace PFEngine.background.parallelscroll {
	public class ParallelLoopManager : MonoBehaviour {
		private ParallelLoopSubject[] subjects;

		public ParallelLoopSubject headSubject;
		public Transform leftPoint;
		public Transform rightPoint;
		public float moveSpeedX = 0f;
		
		// Use this for initialization
		void Start () {
			subjects = gameObject.GetComponentsInChildren<ParallelLoopSubject>();
			
			int bgLength = subjects.Length;
			for (int i = 0; i < bgLength; i++) {
				subjects[i].CalculateOffsetPosition(headSubject.transform.position.x);
			}
		}
		
		// Update is called once per frame
		void Update () {
			int bgLength = subjects.Length;

			if (headSubject != null) {
				headSubject.MoveX(moveSpeedX);
				if (headSubject.transform.position.x < leftPoint.position.x) {
					headSubject.TransportToRightPointX(rightPoint.position.x + (headSubject.transform.position.x - leftPoint.position.x));
				}
			}

			ParallelLoopSubject subject;
			for (int i = 0; i < bgLength; i++) {
				subject = subjects[i];
				if (subject != headSubject) {
					subject.MoveX(moveSpeedX);
					if (subject.transform.position.x < leftPoint.position.x) {
						subject.TransportToRightPointX(rightPoint.position.x - (rightPoint.position.x  - headSubject.transform.position.x));
					}
				}
			}
		}
		
	}
}