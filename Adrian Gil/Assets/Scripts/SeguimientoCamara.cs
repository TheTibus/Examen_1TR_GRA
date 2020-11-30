using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
   
    public Transform posicionJugador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(posicionJugador.position.x, posicionJugador.position.y + 40f, posicionJugador.position.z - 15f);


    }
    
}
