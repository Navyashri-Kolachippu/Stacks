// See https://aka.ms/new-console-template for more information

using Stacks._20ValidParanthesis;

Valid valid = new Valid();
//var a =valid.AsteroidCollision(new[] { 5, 10, -5 });
//Console.WriteLine(string.Join(", ", a));

var b = valid.UniqueOccurrences(new[] { 1, 2, 2, 1, 1, 3 });
Console.WriteLine(b);

int[] nums = new[] { 1, 2, 3, 4, 5, 6, 7 };

valid.Rotate(nums, 3);