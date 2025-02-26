// See https://aka.ms/new-console-template for more information

using Stacks._20ValidParanthesis;
using Stacks.Asteroid;

Asteroid asteroid = new Asteroid();
var a = asteroid.AsteroidCollision(new[] { 5, 10, -5 });
Console.WriteLine(string.Join(", ", a));

