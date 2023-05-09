package oop.b6_1;



public class Main {
    public static void main(String[] args) {
        Rectangle r1 = new Rectangle(1.2f, 3.4f);
        System.out.println(r1);  // toString()
        System.out.printf("area is: %.2f%n", r1.getArea());
        System.out.printf("perimeter is: %.2f%n", r1.getPerimeter());

        Circle c1 = new Circle();
        System.out.println(c1);
        System.out.printf("area is: %.2f%n", c1.getArea());
        System.out.printf("perimeter is: %.2f%n", c1.getPerimeter());
    }
}
