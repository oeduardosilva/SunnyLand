using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour
{

    private string name = "personagem";

    private int health =  100;

    private float velocity = 2.5f;

    private bool life = true;






    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Seu nome �" + name + "sua vida �" + health + "sua velocidade �" + velocity + "caso voce tenha mais que 0 de vida vc esta" + health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
