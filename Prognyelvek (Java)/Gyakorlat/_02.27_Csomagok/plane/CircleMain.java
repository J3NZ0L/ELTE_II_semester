package plane;

public class CircleMain{
    public static void main(String[] args){
        Circle c1 = new Circle();
        System.out.println("Terulet: "+c1.getArea());
        c1.setX(5);
        c1.setY(2);
        c1.setRadius(10);
        System.out.println("Terulet: "+c1.getArea());
    }
}