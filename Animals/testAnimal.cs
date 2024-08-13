using Animals;

List<Animal> animals = new List<Animal>();

animals.Add(new Cat(true, true, 1));

animals.Add(new Dog(true, true, 1));

animals.Add(new Frog(true, true, 1));


foreach (var animal in animals)
{

    Console.WriteLine(animal.GetType().Name);

    animal.SayHello();

    animal.SayHello(1);

    animal.SayHello(0);

    Console.WriteLine();

}


