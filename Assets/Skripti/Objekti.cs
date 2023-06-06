using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//pievienoju masinas objektus
	public GameObject atkritumuMasina, atraPalidziba, autobuss, b2, cementaMasina, e46, e61, eskavators, policija, traktors1, traktors5, ugunsdzeseji;


	[HideInInspector]
	public Vector2 atkrMKoord, atrPKoord, bussKoord;
	[HideInInspector]
	public Vector2 b2Koord, cementaKoord, e46Koord, e61Koord, eskavatorsKoord, policijaKoord, traktors1Koord, traktors5Koord, ugunsdzesejiKoord;


	public Canvas kanva;

	public AudioSource skanasAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;

	//iegust masinu atrasanas vietu
	void Start() {
		atkrMKoord =
        atkritumuMasina.GetComponent<RectTransform>().localPosition;
        
		atrPKoord =
        atraPalidziba.GetComponent<RectTransform>().localPosition;

        bussKoord =
		autobuss.GetComponent<RectTransform>().localPosition;

		b2Koord =
			b2.GetComponent<RectTransform>().localPosition;

		cementaKoord =
			cementaMasina.GetComponent<RectTransform>().localPosition;

		e46Koord =
			e46.GetComponent<RectTransform>().localPosition;

		e61Koord =
			e61.GetComponent<RectTransform>().localPosition;

		eskavatorsKoord =
			eskavators.GetComponent<RectTransform>().localPosition;

		policijaKoord =
			policija.GetComponent<RectTransform>().localPosition;

		traktors1Koord =
			traktors1.GetComponent<RectTransform>().localPosition;

		traktors5Koord =
			traktors5.GetComponent<RectTransform>().localPosition;

		ugunsdzesejiKoord =
			ugunsdzeseji.GetComponent<RectTransform>().localPosition;
    }
}
