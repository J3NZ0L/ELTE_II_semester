public class Circle{
    public Point center;
    public double radius;

    public Circle(    ){
        this.radius=0;
        this.center = new Point();
    }

    public void enlarge(double f){
        this.radius*=f;
    }

    public double getArea(){
        return Math.pow(this.radius,2)*Math.PI;
    }
}