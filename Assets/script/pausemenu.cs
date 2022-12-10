using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
	public GameObject panelPause;
	public void PauseControl()
	{
		if (Time.timeScale == 1)
		{
			panelPause.SetActive (true);
			Time.timeScale = 0;
		}
		else {
			Time.timeScale = 1;
			panelPause.SetActive (false);
		}
	}

	public void Menu()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
	}

	public void MenuUtama()
	{
		Application.LoadLevel(0);
	}

}
