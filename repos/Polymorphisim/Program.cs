/**@author Mikey Dowsett */
Pet[] kennel = new Pet[2];

kennel[0] = new Dog();
kennel[1] = new Cat();

foreach(Pet pet in kennel)
    pet.Speak(3);