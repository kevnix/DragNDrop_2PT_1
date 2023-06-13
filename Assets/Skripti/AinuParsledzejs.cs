using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AinuParsledzejs : MonoBehaviour {
	//parsledzas uz PilsetasKarte ainu
	public void StartGame () {
		SceneManager.LoadScene (1, LoadSceneMode.Single);
	}
	//aptur programmu jeb iziet no speles
	public void QuitGame(){
		Application.Quit ();
	}
	//lauj speles laika nospiest Escape (Esc) pogu lai tiktu atpakal uz sakuma ekranu
	void Update(){
		if (SceneManager.GetActiveScene ().name != "Menu") {
			if (Input.GetKey (KeyCode.Escape)) {
				SceneManager.LoadScene (0, LoadSceneMode.Single);
			}
		}
	}

}
