using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMando : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 40f;
        transform.position = new Vector3(0, 2, 0);
    }

    
    void Update()
    {

       
        MoverJugador();
       
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
