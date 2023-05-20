package day8;


// z = a + bi trong đó: a - phần thực, b - phần ảo, i^2 = -1

public class SoPhuc {
    private double a = 0;
    private double b = 0;

    public SoPhuc() {
    }

    public SoPhuc(double a, double b) {
        this.a = a;
        this.b = b;
    }

    public double getA() {
        return a;
    }

    public void setA(double a) {
        this.a = a;
    }

    public double getB() {
        return b;
    }

    public void setB(double b) {
        this.b = b;
    }

    @Override
    public String toString() {
        return String.format("%.2f + %.2fi \n", a, b);
    }
}
