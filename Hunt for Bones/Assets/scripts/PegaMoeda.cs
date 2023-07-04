using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegaMoeda : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Osso"))
        {
            Destroy(col.gameObject);
            FindObjectOfType<GameManage>().AdicionarMoedas(1);
        }
        if (col.CompareTag("Osso dourado"))
        {
            Destroy(col.gameObject);
            Debug.Log("ganhou");
            FindObjectOfType<GameManage>().Ganhou();
        }
    }
}
