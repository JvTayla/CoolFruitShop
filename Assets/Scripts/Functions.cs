using UnityEngine;

public class Functions : MonoBehaviour
{
        [SerializeField]
        private float celcius = 10;

    private float kelvin;
    private float kelvinDifference = 273.15f;

        private void Start()
        {
            KelvinCalc(celcius,  kelvin);

            //Debug.Log(celcius + "°C + " + kelvinDifference + " = " + kelvin + "K");

            Debug.Log(KelvinCalc(10f, 1f) + "K (Kelvin)");
        }

        private float KelvinCalc(float celcius,  float kelvin)
        {
            kelvin = celcius + kelvinDifference;
        return kelvin;
        
        }

    //private float CToKelvin(float celcius)
    //{
    //     float kelvin = celcius + kelvinDifference;
    //    return kelvin;
    //}


}
