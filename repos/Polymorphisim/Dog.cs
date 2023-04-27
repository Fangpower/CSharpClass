/**@author Mikey Dowsett */
public class Dog : Pet {
    public override void Speak(int numTimes) {
        for (int i = 0; i < numTimes; i++)
            Console.Write("Woof ");
        Console.WriteLine();
    }
}
