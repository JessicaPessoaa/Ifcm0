using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager3 : MonoBehaviour
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
        textoContador.text = "Moedas: " + contador;
    }


    
}