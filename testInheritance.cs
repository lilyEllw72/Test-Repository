
public class testInheritance : testProgram {

  public override void sayHello() {
    Console.WriteLine("Saying hello from child program with no name!");
  }
  public override void sayHello(string name) {
    Console.WriteLine($"Saying hello from child program {name}!");
  }
  
}