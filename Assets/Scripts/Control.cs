using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    public InputField[] ip;
    public Text txt,txt2;
    float value,value2;
    float imc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string var = ip[0].text;
        string var2 = ip[1].text;
        value = float.Parse(var);
        value2 = float.Parse(var2);

        imc = value / (Mathf.Pow(value2,2));

    }


    public void mostrarIMC() {

        txt.text = imc.ToString();

        if(imc > 40)
           txt2.text = "Você está com obesidade morbida";
        if (imc > 18.5 && imc < 24.99)
            txt2.text = "Você está com seu peso ideal, Parabéns";
        if (imc > 25 && imc < 29.99)
            txt2.text = "Você está acima do seu peso ideal";
        if (imc > 30 && imc < 34.99)
            txt2.text = "Você está com obesidade grau 1";
        if (imc > 35 && imc < 39.99)
            txt2.text = "Você está com obesidade grau 2";
        if (imc < 18.5)
            txt2.text = "Você está abaixo do peso ideal"; 
        
    }      
}
