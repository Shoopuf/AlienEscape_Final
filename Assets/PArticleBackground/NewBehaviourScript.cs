using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public GlobalVariables globalVars;
	public ParticleSystem Up;
	public ParticleSystem Down;
	private int emissionRate = 10;
	// Use this for initialization
	void Start () {
		Up.renderer.sortingLayerName = "Background";
		Down.renderer.sortingLayerName = "Background";
	}
	
	// Update is called once per frame
	void Update () {
			float atmosphereVal = globalVars.getAtmosphereSelected();
			if(atmosphereVal == 0){
			Up.renderer.sortingLayerName = "Background";
			Down.renderer.sortingLayerName = "Background";
			//Up.gameObject.SetActive(false);	
			//Down.gameObject.SetActive(false);	

			}else if (atmosphereVal>0){
			Up.renderer.sortingLayerName = "Background";
			Down.renderer.sortingLayerName = "Forground";
			//Up.gameObject.SetActive(false);	
			//Down.gameObject.SetActive(true);	

			}else if (atmosphereVal<0){
			Up.renderer.sortingLayerName = "Forground";
			Down.renderer.sortingLayerName = "Background";
			//Up.gameObject.SetActive(true);	
			//Down.gameObject.SetActive(false);	

			}
	}
}
