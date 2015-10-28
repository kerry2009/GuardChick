using UnityEngine;
using System.Collections;

namespace PFEngine.background.texturescroll {
	public class InfiniteScrollBG : MonoBehaviour {
		private Vector2 materialOffsetVect2;
		private Material backgroundMatrial;
		private BackGroundSetting setting;
		
		void Start () {
			materialOffsetVect2 = new Vector2 ();
		}
		
		public void SetBackgroundMaterial(Material bgMaterial) {
			backgroundMatrial = bgMaterial;
		}
		
		public void SetBackgroundSetting(BackGroundSetting bgSetting) {
			setting = bgSetting;
		}
		
		public void ScrollBG(float offsetX, float offsetY) {
			if (backgroundMatrial != null && setting != null) {
				materialOffsetVect2.x = Mathf.Repeat (materialOffsetVect2.x + offsetX * setting.ratioX, 1.0f);
				materialOffsetVect2.y = Mathf.Repeat (materialOffsetVect2.y + offsetY * setting.ratioY, 1.0f);
				backgroundMatrial.SetTextureOffset ("_MainTex", materialOffsetVect2);
			} else {
				Debug.Log("Warn! : Background matrial or setting is null!");
			}
		}
		
		void OnDisable () {
			if (backgroundMatrial != null) {
				backgroundMatrial.SetTextureOffset ("_MainTex", Vector2.zero);
			}
		}
		
	}
}