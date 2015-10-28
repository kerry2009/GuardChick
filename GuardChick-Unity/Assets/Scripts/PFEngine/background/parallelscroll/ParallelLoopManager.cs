using UnityEngine;
using System.Collections;
using PFEngine.background.parallelscroll;

namespace PFEngine.background.parallelscroll {
	public class ParallelLoopManager : MonoBehaviour {
		private ParallelLoopSubject[] subjects;
		
		public Transform startPoint;
		public Transform endPoint;
		public float moveSpeedX = 0f;
		
		// Use this for initialization
		void Start () {
			subjects = gameObject.GetComponentsInChildren<ParallelLoopSubject>();
			
			int bgLength = subjects.Length;
			for (int i = 0; i < bgLength; i++) {
				subjects[i].CalculateOffsetPosition(startPoint.position.x);
			}
		}
		
		// Update is called once per frame
		void Update () {
			int bgLength = subjects.Length;
			
			ParallelLoopSubject subject;
			for (int i = 0; i < bgLength; i++) {
				subject = subjects[i];
				subject.MoveX(moveSpeedX);
				if (subject.transform.position.x < startPoint.position.x) {
					subject.TransportToEndPointX(endPoint.position.x + (startPoint.position.x - subject.transform.position.x));
				}
			}
		}
		
	}
}