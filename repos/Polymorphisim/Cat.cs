/**@author Mikey Dowsett */
public class Cat : Pet {
    public override void Speak(int numTimes) {
        for (int i = 0; i < numTimes; i++)
            Console.Write("Meow ");
        Console.WriteLine();
    }
}