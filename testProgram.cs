
public class testProgram {

  private string name = "John";

  public void setName(string newName) {
      name = newName;
  }

  public String getName() {
    return name;
  }

  public virtual void sayHello() {
    Console.WriteLine("Hello Mike!");
  }
  public virtual void sayHello(string name) {
    Console.WriteLine($"Hello {name}!");
  }
}
