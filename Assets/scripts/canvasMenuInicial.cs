using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class canvasMenuInicial : MonoBehaviour
{
    public Slider sliderVolumen;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Valor de Slider: " + sliderVolumen.value.ToString());
    }

    public void BotonIniciar(){
        Debug.Log("Iniciar...");
        SceneManager.LoadScene(1);
    }

    public void BotonSalir(){
        Debug.Log("Estoy en cualquier otra aplicacion y sali");
        Application.Quit();
    }

    public void CambioValor(){
        Debug.Log("Valor de Slider: " + sliderVolumen.value.ToString());
    }
}
