using UnityEngine;
using System.Collections;

namespace PFEngine.background.texturescroll {
	public class InfiniteScrollBGManager : MonoBehaviour {
		public float ScrollSpeedX = 0.0f;
		public float ScrollSpeedY = 0.0f;

		public BackGroundSetting[] backGrounds = null;
		private InfiniteScrollBG[] infiniteScrollBGs = null;

		void Start () {
			if (backGrounds != null) {
				int bgLength = backGrounds.Length;
				infiniteScrollBGs = new InfiniteScrollBG[bgLength];

				for (int i = 0; i < bgLength; i++) {
					// set back grounds scroll component
					backGrounds[i].gameObject.AddComponent<InfiniteScrollBG>();
					infiniteScrollBGs[i] = backGrounds[i].GetComponent<InfiniteScrollBG>();
					infiniteScrollBGs[i].SetBackgroundMaterial(infiniteScrollBGs[i].GetComponent<Renderer>().sharedMaterials[0]);
					infiniteScrollBGs[i].SetBackgroundSetting(backGrounds[i]);
				}
			}
		}

		void Update () {
			ScrollBGs (ScrollSpeedX, ScrollSpeedY);
		}

		public void ScrollBGs(float offsetX, float offsetY) {
			if (infiniteScrollBGs != null) {
				int bgLength = infiniteScrollBGs.Length;
				for (int i = 0; i < bgLength; i++) {
					infiniteScrollBGs[i].ScrollBG(offsetX, offsetY);
				}
			}
		}

	}
}