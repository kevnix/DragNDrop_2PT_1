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

}
