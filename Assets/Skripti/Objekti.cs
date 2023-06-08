using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject cementaMasina;
	public GameObject e46;
	public GameObject e61;
	public GameObject eskavators;
	public GameObject policija;
	public GameObject traktors1;
	public GameObject traktors5;
	public GameObject ugunsdzeseji;

	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atraPKoord;
	[HideInInspector]
	public Vector2 autobussKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 cemMKoord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 e61Koord;
	[HideInInspector]
	public Vector2 eskKoord;
	[HideInInspector]
	public Vector2 polKoord;
	[HideInInspector]
	public Vector2 trak1Koord;
	[HideInInspector]
	public Vector2 trak5Koord;
	[HideInInspector]
	public Vector2 ugunsKoord;

	public Canvas kanva;

	public GameObject poga; //restart spele
	public GameObject kartinka; //izkartne
	public GameObject tekst; //tekts kur bus redz rezultats 
	public int masinasSkaits=0; //siet vus skitijas cik masinas obcektas ir savas vitetas
	private float sakumaLaiks; // laiku skaitisana
	public GameObject s1; //pirma zvaigzne
	public GameObject s2; //otra zvaigzne
	public GameObject s3; //treša zvaigzne

	public AudioSource audioAvots;
	public AudioClip[] skanasKoatskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;

	void Start () {
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
		atraPKoord = atraPalidziba.GetComponent<RectTransform>().localPosition;
		autobussKoord = autobuss.GetComponent<RectTransform>().localPosition;
		b2Koord = b2.GetComponent<RectTransform>().localPosition;
		cemMKoord = cementaMasina.GetComponent<RectTransform>().localPosition;
		e46Koord = e46.GetComponent<RectTransform>().localPosition;
		e61Koord = e61.GetComponent<RectTransform>().localPosition;
		eskKoord = eskavators.GetComponent<RectTransform>().localPosition;
		polKoord = policija.GetComponent<RectTransform>().localPosition;
		trak1Koord = traktors1.GetComponent<RectTransform>().localPosition;
		trak5Koord = traktors5.GetComponent<RectTransform>().localPosition;
		ugunsKoord = ugunsdzeseji.GetComponent<RectTransform>().localPosition;
		sakumaLaiks = Time.time; //laiks ir sācis skaitīties
	}
	//Spele parbaude un rezultate paradisana
	public void parbaudisana() {
		if (masinasSkaits >= 12) { //Ja visas mašīnas atrodas pareizajās vietās
			kartinka.SetActive(true); //Parādās izkartne
			poga.SetActive(true); //Parādās poga
			tekst.SetActive(true); //Parādās teksta 
			float cikLaiks = Time.time - sakumaLaiks; //skaitijas cik laiku izmantojat speletajs lai pevinot visas objecti savas pareizas vietas 
			int stundas = (int) cikLaiks / 3600; //aprēķina stundas
			int minutes = (int) (cikLaiks%3600) / 60; //aprēķina minutes
			int sekundes = (int) (cikLaiks%3600) % 60; //aprēķina sekundes
			string laiks = string.Format("{0:00}:{1:00}:{2:00}", stundas, minutes, sekundes); //izradas visu no hh:mm:ss formata
			string str = "Tavs rezultats: \n" + laiks; //teksta saglabāšana
			tekst.GetComponent<Text>().text = str; //teksts saglabā teksta lodziņā
			if (minutes<1) //ja spiele iet mazat beka 1 minute
			{
				s1.SetActive(true); //visas zvaigznes ir redzamas
				s2.SetActive(true);
				s3.SetActive(true);
			}else if(minutes<2) //ja spelie iet mazak neka 2 minute
			{
				s1.SetActive(true); //radas tikai 2 zvaigznes
				s2.SetActive(true);
			}
			else //ja spele ied 2 minutes un ilgak
			{
				s1.SetActive(true); //radas tikai 1 zvaigzne
			}
		}
	}

}
