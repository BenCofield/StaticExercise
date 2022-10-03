using StaticExercise;
using System;


double newYorkTempF = 52;
double newYorkTempC = TempConverter.FahrenheitToCelsius(newYorkTempF);
double londonTempC = 18;
double londonTempF = TempConverter.CelsiusToFahrenheit(londonTempC);

Console.WriteLine($"It is {newYorkTempF}°F ({Math.Round(newYorkTempC)}°C) in New York City today");
Console.WriteLine($"It is {londonTempC}°C ({Math.Round(londonTempF)}°F) in London today");