package oop.b4_6;



public class Main {
    public static void main(String[] args) {
//        Cat c1 = new Cat();
//        c1.makeSound();
//
//        Dog d1 = new Dog();
//        d1.makeSound();
        // Tao ra 1 mang cac con vat
        Animal[] animals = new Animal[4];
        animals[0] = new Cat();
        animals[1] = new Dog();
        animals[2] = new Dog();
        animals[3] = new Cat();

        for (Animal animal : animals) {
            animal.makeSound();
        }

    }
}
