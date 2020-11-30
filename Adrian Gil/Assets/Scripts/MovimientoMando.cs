using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoMando : MonoBehaviour
{
    //UltimoComitParaQueLosVeasTodosJuntos
    public float speed;
    public float contador;
    public Text puntuacion;


    // Start is called before the first frame update
    void Start()
    {
        speed = 60f;
        transform.position = new Vector3(0, 2, 0);
        contador = 0;
        puntuacion.text = "Puntuación: 0";
    }

    
    void Update()
    {

       
        MoverJugador();
        
    }

    public void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
        contador = contador + 1;
        puntuacion.text = "Puntuación:  " + contador;
       
    }
    void MoverJugador()
    {

        float posX = transform.position.x;
        float posZ = transform.position.z;
        float desplZ = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");

        //restringir movimiento en el eje X
        if (posX < 34 && posX > -34 || posX < -14 && desplX > 0 || posX > 14 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }

        //restringir movimiento en el eje Z
        if (posZ < 34 && posZ > -34 || posZ < 1 && desplZ > 0 || posZ > 10 && desplZ < 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * desplZ);
        }
    }


}
