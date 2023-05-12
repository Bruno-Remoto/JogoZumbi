using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{
    public GameObject Tiro;
    public GameObject Jogador;
    public Camera camerazinha;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bala = Instantiate(Tiro, Jogador.transform.position, Jogador.transform.rotation);
        }
    }
}
