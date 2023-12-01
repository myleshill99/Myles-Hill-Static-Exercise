using StaticExercise;
using System;

var celcius = TempConverter.FahrenheitToCelsius(68); //20 
var fahrenheit = TempConverter.CelsiusToFahrenheit(20); //68

Console.WriteLine ("After conversion:");
Console.WriteLine($"celsius {celcius}");
Console.WriteLine("fahrenheit {fahrenheit}");
