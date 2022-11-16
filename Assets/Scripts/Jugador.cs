using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public bool IJ;
    private bool Saltando;
    private bool Deslizando;
    Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        IJ = false;
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && IJ==false) 
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 13, 0);
            IJ = true;
            Anim.SetBool("Saltando", true);
            Saltando = true;
        }

        if (Input.GetKey(KeyCode.DownArrow) && IJ == false)
        {
            IJ = true;
            Anim.SetBool("Deslizando", true);
            Deslizando = true;
        }

    }

    void OnCollisionEnter2D(Collision2D Coll)
    {
        if(Coll.gameObject.tag=="Finish")
        {
            IJ = false;
            Anim.SetBool("Saltando", false);
            Saltando = false;
            Anim.SetBool("Deslizando", false);
            Deslizando = false;
            
        }
        if (Coll.gameObject.tag=="Respawn")
        {
            Application.LoadLevel("dino");
        }
    }
}
