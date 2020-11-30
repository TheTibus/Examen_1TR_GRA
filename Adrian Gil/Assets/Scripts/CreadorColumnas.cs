using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorColumnas : MonoBehaviour
{
    public int numeroColumnas = 0;
    [SerializeField] GameObject columnas;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ColumnCorrutine");
    }

    // Update is called once per frame
    void Update()
    {

    }


    void CrearColumna()
    {

        float posRandom = Random.Range(-34, 34);
        float posRandom2 = Random.Range(-34, 34);

        Vector3 DestPos = new Vector3(posRandom, 0, posRandom2);
        Instantiate(columnas, DestPos, Quaternion.identity);
        numeroColumnas ++;
        print(numeroColumnas);
    }
   
    IEnumerator ColumnCorrutine()
    {
        for(int n = 0; ; n++)
        {
            CrearColumna();
           
            if (numeroColumnas <= 5)
            {
                print("Pasan 1 segundos");
                yield return new WaitForSeconds(1);
               
            }
            else if (numeroColumnas <= 10)
            {
                print("Pasan 5 segundos");
                yield return new WaitForSeconds(5);
                
            }
            else
            {
                print("Pasan 10 segundos");
                yield return new WaitForSeconds(10);
                
            }

        }
    }
    
}