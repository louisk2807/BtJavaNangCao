package oop.b6_8;

import oop.b6_3.MovablePoint;

public class Main {
    public static void main(String[] args) {
        MovablePoint point = new MovablePoint(1, 2, 3, 4);
        point.moveUp();
        point.moveLeft();
        System.out.println(point);

        MovableCircle circle = new MovableCircle(0, 0, 1, 1, 5);
        circle.moveRight();
        circle.moveDown();
        System.out.println(circle);
    }
}
