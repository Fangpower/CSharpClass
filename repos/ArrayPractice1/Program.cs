
using static System.Formats.Asn1.AsnWriter;
/**
 * @author Mikey Dowsett
 */
const int NUM_SCORES = 25;

int[] scores = new int[NUM_SCORES];

for(int i = 0; i < scores.Length; i++)
    scores[i] = i;

for(int i = 0; i < scores.Length; i++)
    Console.Write($"{scores[i]} ");

Console.WriteLine();

foreach(int score in scores)
    Console.Write($"{score} ");