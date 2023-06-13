using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rezultats : MonoBehaviour {
	public GameObject mainigaisAttels;
	public Sprite[] atteluMasivs;

	//definé publisku teksta tipa mainígo, kas mums paradis taimeri
	public Text timerText;

	private void Start(){
		float currentTime = Timer.taimeris.currentTime;
		// timerText pieskir timer string	
		timerText.text = parveidotLaiku(currentTime);
		paraditZvaigznes (currentTime);
	}


	//metode kas parveido laiku formata hh:mm:ss
	private string parveidotLaiku(float time){
		int h = Mathf.FloorToInt (Timer.taimeris.currentTime / 3600);
		int m = Mathf.FloorToInt ((Timer.taimeris.currentTime % 3600) / 60);
		int s = Mathf.FloorToInt (Timer.taimeris.currentTime % 60);

		return string.Format ("{0:00}:{1:00}:{2:00}", h, m, s);
	}

	public void paraditZvaigznes(float time){
		if (time <= 120) {
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [3];
		} else if (time > 120 && time < 180) {
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [2];
		} else if (time > 180 && time < 240) {
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [1];
		} else if (time > 240) {
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [0];
		}
	}	
		
}
