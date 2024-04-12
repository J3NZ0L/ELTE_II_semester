public class Linemain{
    public static void main(String[] args){
        Line l1=new Line();
        Line l2=new Line();
        Point p1=new Point();

        l1.a=1;
        l1.b=2;
        l1.c=4;
        l2.a=3;
        l2.b=4;
        l2.c=3;
        p1.x=0;
        p1.y=2;

        System.out.println(l1.contains(p1));


    }

}