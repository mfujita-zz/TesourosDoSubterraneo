using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TelaIntroController : MonoBehaviour 
{
    public Text hudRecorde;
	
	void Start () 
    {
        if (PlayerPrefs.HasKey("RECORDE"))
        {
            hudRecorde.text = string.Format("RECORDE: {0}", PlayerPrefs.GetInt("RECORDE"));
        }
        else
        {
            hudRecorde.text = "Recorde: Não há recordes";
        }
	}
	
    public void LimpaRecorde()
    {
        Debug.Log(PlayerPrefs.HasKey("RECORDE"));
        if (PlayerPrefs.HasKey("RECORDE"))
        {
            PlayerPrefs.DeleteKey("RECORDE");
            hudRecorde.text = "Recorde: Não há recordes";
        }
    }

    public void Play()
    {
        SceneManager.LoadScene("cena1");
    }

    public void Sair()
    {
        Application.Quit();
    }
}
