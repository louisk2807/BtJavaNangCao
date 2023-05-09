package oop.b6_1;

public class Circle extends Shape {
    protected double radius = 1.0;
    public Circle(){
    }

    public Circle(String color, boolean filled, double radius) {
        super(color, filled);
        this.radius = radius;
    }

    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) {
        this.radius = radius;
    }
    public double getArea() {

        return Math.PI * radius * radius;
    }
    public double getPerimeter(){
        return 2* Math.PI *radius;
    }

    @Override
    public String toString() {
        return "Circle[" +
                "radius=" + radius +
                ", color='" + color + '\'' +
                ", filled=" + filled +
                ']';
    }
}
