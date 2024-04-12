package plane;

public class Circle{ //DB7ZTC
    private double x;
    private double y;
    private double radius;

    public Circle(){
        this.radius=0;
        this.x=0;
        this.y=0;
    }

    public double getX(){
        return this.x;
    }
    public double getY(){
        return this.y;
    }
    public double getRadius(){
        return this.radius;
    }

    public void setX(double _x){
        this.x=_x;
    }
    public void setY(double _y){
        this.y=_y;
    }
    public void setRadius(double _radius){
        if (_radius<=0){
            throw new IllegalArgumentException("A sugarnak poztivnak kell lennie.");
        } else {
        this.radius=_radius;
        }
    }

    
    

    public void enlarge(double f){
        this.radius*=f;
    }

    public double getArea(){
        return Math.pow(this.radius,2)*Math.PI;
    }
}