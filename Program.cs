// See https://aka.ms/new-console-template for more information
// dotnet new console

public class Program {
  public static void Main(string[] args) {

    testProgram test = new testProgram();
    testInheritance test2 = new testInheritance();

    test.sayHello();
    test.sayHello("Lily");
    test.setName("Taylor");

    test2.sayHello();
    test2.sayHello("Taylor");
  }
}
