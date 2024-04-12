package plane.but.not.flying;
import plane.*;

public class CircleMain{
    public static void main(String[] args){
        PublicCircle c1 = new PublicCircle();
        System.out.println("Terulet: "+c1.getArea());
        c1.x=5;
        c1.y=2;
        c1.radius=10;
        System.out.println("Terulet: "+c1.getArea());
    }

}