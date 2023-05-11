package oop.b6_3;

public class Main {
    public static void main(String[] args) {
        MovablePoint point = new MovablePoint(0, 0, 2, 3);
        System.out.println("Initial point: " + point);

        point.moveUp();
        point.moveRight();
        System.out.println("After moving up and right: " + point);

        point.moveDown();
        point.moveLeft();
        System.out.println("After moving down and left: " + point);
    }
}
