// See https://aka.ms/new-console-template for more information
// dotnet new console

//Hello Mike!
//Hello Larry!
public class Program {
  public static void Main(string[] args) {
    testProgram test = new testProgram();
    
    Console.WriteLine($"Hello {test.getName()}");
    test.setName("Lily");
    Console.WriteLine($"Hello {test.getName()}");
  }
}
