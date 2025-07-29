using System;

public class Program {
    static void Main(String[] args) {
        Vector2D vector = new Vector2D(1.0, 1.0);
        Console.WriteLine(vector.getMagnitude());
        vector.normalize();
        Console.WriteLine(vector.getMagnitude());
    }
}

public class Vector2D {
    public Vector2D(double x, double y) {
        this.x = x;
        this.y = y;
    }

    private double x;
    private double y;

    public double getX() {
        return this.x;
    }

    public double getY() {
        return this.y;
    }

    public void setX(double x) {
        this.x = x;
    }

    public void setY(double y) {
        this.y = y;
    }

    public void normalize() {
        double x = this.getX();
        double y = this.getY();
        double magnitude = this.getMagnitude();
        if (magnitude == 0) return;
        this.setX(x / magnitude);
        this.setY(y / magnitude);
    }

    public double getMagnitude() {
        return Math.Sqrt((this.getX() * this.getX()) + (this.getY() * this.getY()));
    }
}
