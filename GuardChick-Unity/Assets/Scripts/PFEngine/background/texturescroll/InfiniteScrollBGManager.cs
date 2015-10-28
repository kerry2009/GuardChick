using UnityEngine;
using System.Collections;

namespace PFEngine.background.texturescroll {
	public class InfiniteScrollBGManager : MonoBehaviour {
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
			ScrollBGs (0.001f, 0f);
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