package oop.b4_6;

public class Dog extends Mammal{
    public Dog(String name) {
        super(name);
    }

    public Dog() {

    }

    @Override
    public void makeSound() {
        System.out.println("Woof");
    }
}
