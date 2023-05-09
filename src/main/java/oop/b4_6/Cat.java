package oop.b4_6;

public class Cat extends Mammal  {
    public Cat(String name) {
        super(name);
    }

    public Cat() {
        super();
    }

    @Override
    public void makeSound() {
        System.out.println("Meow");
    }

}
