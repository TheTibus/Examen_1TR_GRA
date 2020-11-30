using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorColumnas : MonoBehaviour
{

    //UltimoComitParaQueLosVeasTodosJuntos
    public float numeroColumnas;

    [SerializeField] GameObject columnas;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ColumnCorrutine");
        numeroColumnas = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void CrearColumna(){

        float posRandom = Random.Range(-34, 34);
        float posRandom2 = Random.Range(-34, 34);

        Vector3 DestPos = new Vector3(posRandom, 5, posRandom2);
        Instantiate(columnas, DestPos, Quaternion.identity);
        numeroColumnas++;
        print(numeroColumnas);
     }

     

     IEnumerator ColumnCorrutine()
        {
         for(int n = 0; ; n++)
         {
             CrearColumna();

             if (numeroColumnas <= 15)
             {
                
                // print("Pasan 1 segundos"); 
                yield return new WaitForSeconds(0.5f);
               
            }
            else if (numeroColumnas <= 30)
            {
                
                //print("Pasan 5 segundos");
                yield return new WaitForSeconds(2f);
                
            }
            else
            {
                
                // print("Pasan 10 segundos"); 
                yield return new WaitForSeconds(5f);
                
            }

        }
        }
}

