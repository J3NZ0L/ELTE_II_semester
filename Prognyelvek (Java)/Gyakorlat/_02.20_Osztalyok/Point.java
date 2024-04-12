public class Point{ //DB7ZTC

    private double x;
    public double y;

    public double getX(){
        return x;
    }

    public void setX(double _x){
        this.x=_x;
    }

    public Point (){
        this.x=0.0;
        this.y=0.0;
    }

    void move(double dx, double dy){
        this.x+=dx;
        this.y+=dy;
    }
    
    void mirror(Point p){
        this.x=p.x-(x-p.x); //2*cx - x;
        this.y=p.y-(y-p.y);
    }

    void printPoint(){
        System.out.println("Pont koordinatai: ("+x+","+y+")");
    }

    double distance( Point p){
        return Math.sqrt(Math.pow(this.x-p.x,2)+Math.pow(this.y-p.y,2));
    }
}