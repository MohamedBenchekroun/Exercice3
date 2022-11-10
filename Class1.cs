using system;
public class Point
{
    public float x;
    public float y;
    public int Getx()
    {
        return x;


    }
    public void Setx(float ax)
    {
        this.x = x;

    }
    public int Gety()
    {
        return y;
    }
    public void Sety(float ay)
    {
        this.y = y;

    }
    public float distance(Point p1)
    {
        float dis = (float)Math.Sqrt(Math.Pow(x - p1.x, 2) + Math.Pow(y - p1.x, 2));
        return dis;
    }
    public bool Egalite(Point p1)
    {
        if (x == p1.x && y == p1.y)
            return true;

        return false;
    }
    public void translation(float a)
    {
        x += a;
        y += a;
    }
}