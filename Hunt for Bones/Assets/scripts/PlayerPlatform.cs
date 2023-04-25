using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatform : MonoBehaviour
{

    public int velocidade;
    public int forcaPulo;
    public bool noAr;
    public SpriteRenderer visual;


    // Start is called before the first frame update
    void Start()
    {
        
    }




    private void OnCollisionStay2D(Collision2D collision)
    {
        noAr = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        noAr = true;
    }




    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        Vector3 inputTeclado = new Vector3(x, 0, 0);
        transform.position += inputTeclado * velocidade * Time.deltaTime;


        if (Input.GetKeyDown(KeyCode.Space) && !noAr)
        {
            Debug.Log("PRESSIONOU");
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
        }
        
        if(x < 0)
        {
            //olhando pra esquerda
            visual.flipX = true;
        }
        else if(x > 0)
        {
            //olhando pra direita
            visual.flipX = false;
        }



    }
}
