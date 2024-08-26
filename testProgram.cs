
public class testProgram {

  private string name = "John";

  public void setName(string newName) {
    if(newName == "Julia") {
      name = newName;
    }
  }

  public String getName() {
    return name;
  }

  public void sayHello() {
    Console.WriteLine("Hello Mike!");
  }
  public void sayHello(string name) {
    Console.WriteLine($"Hello {name}!");
  }
}
