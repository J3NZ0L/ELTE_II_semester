public class CircleMain{
    public static void main( String[] args){
        Circle c1= new Circle();
        c1.center.x=2;
        c1.center.y=3;
        c1.radius=3;
        System.out.println("Kor terulete: "+c1.getArea());
    }
}