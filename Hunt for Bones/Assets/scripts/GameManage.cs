using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManage : MonoBehaviour
{
    public TextMeshProUGUI mensagem, textoContador;
    public int contador;


    // Start is called before the first frame update
    void Start()
    {
        //mostrar mensagem inicial
        mensagem.text = "Vai!";
        Invoke("ModificarMensagem", 5);
        
    }

    void ModificarMensagem()
    {
        mensagem.text = "";
    }

    public void AdicionarMoedas(int valor)
    {
        //somar os pontos
        contador += valor;

        //mudar o texto
        textoContador.text = "Ossos: " + contador;
    }


    public void Ganhou()
    {
        mensagem.text = "Ganhou";
        Invoke("ModificarMensagem", 2);
        Invoke("CarregarFase", 2.01f);
    }

    void CarregarFase()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    
}