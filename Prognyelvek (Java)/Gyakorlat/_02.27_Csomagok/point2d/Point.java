package point2d;

public class Point{ //DB7ZTC

    public double x = 0.0;
    public double y = 0.0;

    public Point (){
        this.x=0.0;
        this.y=0.0;
    }

    public void move(double dx, double dy){
        this.x+=dx;
        this.y+=dy;
    }
    
    public void mirror(Point p){
        this.x=p.x-(x-p.x); //2*cx - x;
        this.y=p.y-(y-p.y);
    }

    public void printPoint(){
        System.out.println("Pont koordinatai: ("+x+","+y+")");
    }

    public double distance( Point p){
        return Math.sqrt(Math.pow(this.x-p.x,2)+Math.pow(this.y-p.y,2));
    }
}