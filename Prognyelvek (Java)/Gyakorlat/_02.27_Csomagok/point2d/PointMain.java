package point2d;

public class PointMain{ //DB7ZTC
    public static void main( String[] args ){
        
        Point p1 = new Point();
       //2. feladat
        p1.x=3.0;
        p1.y=4.0;
        Point p2= new Point();
        p2.x=5.0;
        p2.y=6.0;
        System.out.println(p1.distance(p2));
        
    }
}