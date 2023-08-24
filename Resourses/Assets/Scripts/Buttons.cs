using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Buttons : MonoBehaviour {
	
	public GameObject m_on, m_off;
	public Sprite layer_blue, layer_red;

	void Start (){
		if (gameObject.name == "Music"){
			if (PlayerPrefs.GetString("Music") != "no"){
				m_on.SetActive(true);
				m_off.SetActive(false);
			}
			else {
				m_on.SetActive(false);
				m_off.SetActive(true);
			}
		}
	}

	void Update (){
		if (gameObject.name == "Music"){
			if (PlayerPrefs.GetString("Music") != "no"){
				m_on.SetActive(true);
				m_off.SetActive(false);
			}
			else {
				m_on.SetActive(false);
				m_off.SetActive(true);
			}
		}
	}

	void OnMouseDown () {
		GetComponent <SpriteRenderer> ().sprite = layer_red;
	}

	void OnMouseUp () {
		GetComponent <SpriteRenderer> ().sprite = layer_blue;
	}

	void OnMouseUpAsButton () {
		switch (gameObject.name) {
		case "Play":
			Application.LoadLevel ("play");
			break;
		case "Rating":
			Application.OpenURL ("http://google.com");
			break;
		case "Home":
			Application.LoadLevel ("main");
			break;
		case "Replay":
			Application.LoadLevel ("play");
			break;
		case "How To":
			Application.LoadLevel ("howTo");
			break;
		case "Music":
			if (PlayerPrefs.GetString("Music") != "no"){
				PlayerPrefs.SetString("Music", "no");
				m_on.SetActive(true);
				m_off.SetActive(false);
			}
			else {
				PlayerPrefs.SetString("Music", "yes");
				m_on.SetActive(false);
				m_off.SetActive(true);
			}
			break;
		}
	}
}