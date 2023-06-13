using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	//define timeri
	//statistiska, lai varetu pieklut no citiem skriptiem
	public static Timer taimeris;

	[HideInInspector]
	public float currentTime = 0f;

	//sis kods darbojas kad tiek atverta aina
	void Awake()
	{
		if(taimeris != null)
			GameObject.Destroy(taimeris);
		else
			taimeris = this;
		DontDestroyOnLoad(this);

	}
	//pievieno starp kadru iztereto laiku taimerim
	void Update () {
		currentTime += Time.deltaTime;
		//Debug.Log (taimeris);
	}

	//definé publisku teksta tipa mainígo, kas mums paradis taimeri
	public Text timerText;

	//metode kas parveido laiku formata hh:mm:ss
	private string parveidotLaiku(float time){
		int h = Mathf.FloorToInt (Timer.taimeris.currentTime / 3600);
		int m = Mathf.FloorToInt ((Timer.taimeris.currentTime % 3600) / 60);
		int s = Mathf.FloorToInt (Timer.taimeris.currentTime % 60);

		return string.Format ("{0:00}:{1:00}:{2:00}", h, m, s);
	}	
}
