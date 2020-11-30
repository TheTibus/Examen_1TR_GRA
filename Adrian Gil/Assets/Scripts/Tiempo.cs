using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{
    
    [SerializeField] Text TimePlayed;
    float tiempo;
    float minutos;
    float segundos;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update() {

        UIMarcadores();
    }
    

    

void UIMarcadores()
{
    tiempo += Time.deltaTime;
    segundos = (int)tiempo % 60;
    minutos = (int)((tiempo / 60) % 60);
    TimePlayed.text = "Tiempo: " + minutos.ToString("00") + ":" + segundos.ToString("00");
   

}
}
