package plane;


public class PublicCircle{ //DB7ZTC
    public double x;
    public double y;
    public double radius;

    public PublicCircle(    ){
        this.radius=0;
        this.x=0;
        this.y=0;
    }

    public void enlarge(double f){
        this.radius*=f;
    }

    public double getArea(){
        return Math.pow(this.radius,2)*Math.PI;
    }
}