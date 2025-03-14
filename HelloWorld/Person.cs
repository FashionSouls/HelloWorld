namespace Classes;

public class Person {
    public int Age { get; }
    public string Name { get; }

    // Class function
    public string Greeting() {
        return "Hi, my name is " + Name + ", my age is " + Age + ". Hello World!";
    }

    // Constructor
    public Person(int age, string name) {
        this.Age = age;
        this.Name = name;
    }
}