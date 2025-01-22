using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Thermomètre.Classes;

internal class Thermometre
{

    private double _temperatureKelvin;

	public double TemperatureKelvin { get; set; }
    public double TemperatureCelcius => (TemperatureKelvin - 273.15);
    public double TemperatureFarenheit => ((TemperatureKelvin-273.15) * (9/5) + 32 );


	public Thermometre(double temperature, UniteTemperature typeTemperature)
    {
        Console.WriteLine(Enum.GetValues(typeTemperature.GetType()));

		switch (typeTemperature)
		{
			case UniteTemperature.Celsius:
				TemperatureKelvin = temperature + 273.15;
				break;
			case UniteTemperature.Kelvin:
				TemperatureKelvin = temperature;
                break;
			case UniteTemperature.Fahrenheit:
				TemperatureKelvin = (temperature - 32) * (5 / 9) + 273.15;
				break;
			default:
				break;
		}
    }

    public override string ToString()
    {
        //Console.WriteLine("Temp celcius: "+ TemperatureCelcius);
        //Console.WriteLine("Temp kelv: "+ TemperatureKelvin);
        //Console.WriteLine("Temp far: "+ TemperatureFarenheit);
        return $"Il fait {TemperatureKelvin} °K."
		      +$"\nIl fait {TemperatureCelcius} °C."
			  + $"\nIl fait {TemperatureFarenheit} °F.";
    }


	public static Thermometre operator + (Thermometre t1, double temperature)
	{
		return new Thermometre(t1.TemperatureKelvin + temperature, UniteTemperature.Kelvin);  
	}
}
