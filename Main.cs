using System;

public class Program {
    static void Main(String[] args) {
        Vector2D vector = new Vector2D(1.0, 1.0);
        Console.WriteLine(vector.GetMagnitude());
        vector.Normalize();
        Console.WriteLine(vector.GetMagnitude());
    }
}

public class Vector2D {
    public Vector2D(double x, double y) {
        this.x = x;
        this.y = y;
    }

    private double x;
    private double y;

    public double GetX() {
        return this.x;
    }

    public double GetY() {
        return this.y;
    }

    public void SetX(double x) {
        this.x = x;
    }

    public void SetY(double y) {
        this.y = y;
    }

    public void Normalize() {
        double x = this.GetX();
        double y = this.GetY();
        double magnitude = this.GetMagnitude();
        if (magnitude == 0) return;
        this.SetX(x / magnitude);
        this.SetY(y / magnitude);
    }

    public double GetMagnitude() {
        return Math.Sqrt((this.GetX() * this.GetX()) + (this.GetY() * this.GetY()));
    }
}
