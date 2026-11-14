using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject settingsPanel;
    public GameObject scoresPanel;
    public GameObject creditsPanel;

    void Start()
    {
        MostrarPrincipal();
    }

    public void MostrarPrincipal()
    {
        mainPanel.SetActive(true);
        settingsPanel.SetActive(false);
        scoresPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    public void AbrirAjustes()
    {
        mainPanel.SetActive(false);
        settingsPanel.SetActive(true);
        scoresPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    public void AbrirPuntuaciones()
    {
        mainPanel.SetActive(false);
        settingsPanel.SetActive(false);
        scoresPanel.SetActive(true);
        creditsPanel.SetActive(false);
    }

    public void AbrirCreditos()
    {
        mainPanel.SetActive(false);
        settingsPanel.SetActive(false);
        scoresPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }

    public void Salir()
    {
        Application.Quit();
    }
    public void CambiarBrillo(float valor)
    {
        UnityEngine.UI.Image imagen = GameObject.Find("PanelBrillo").GetComponent<UnityEngine.UI.Image>();
        Color color = imagen.color;
        color.a = 1f - valor;
        imagen.color = color;
    }
    public void CambiarPantallaCompleta(bool activar)
    {
        Screen.fullScreen = activar;
    }
     public void Jugar()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void CambiarCalidad(int calidad)
    {
        int nivel = calidad + 1;

        if (calidad == 3)
        {
            nivel = 5;
        }

        QualitySettings.SetQualityLevel(nivel);
    }
}
