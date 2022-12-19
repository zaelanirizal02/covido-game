using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
	public GameObject panelPause;
	public GameObject CanvasMulai;
	
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

	public void Restart()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
	}

	public void MenuUtama()
	{
		Application.LoadLevel(0);
	}

		public void Mulai()
	{
		Time.timeScale = 1;
		CanvasMulai.SetActive(false);
		
	}

		public void lanjutke2()
	{
		SceneManager.LoadScene(3);
		
	}

		public void lanjutke3()
	{
		SceneManager.LoadScene(4);
		
	}

}
