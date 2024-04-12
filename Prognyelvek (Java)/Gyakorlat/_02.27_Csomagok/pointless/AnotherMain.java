package pointless;

import point2d.Point; //ezzel lehet nelkulozni az osztalyok teljes minositett nevet a gyokerkonyvtarhoz kepest
//import point2d.*; //csak a packageben szereplo class  fileok helyettesitodnek be, nem rekurziv, csak pont a megadott mappaban levo fajlokat nezi, nem megy lejjebb

public class AnotherMain{ //DB7ZTC
    public static void main( String[] args ){
        
        point2d.Point p1 = new point2d.Point();
       //2. feladat
        p1.x=3.0;
        p1.y=4.0;
        point2d.Point p2= new point2d.Point();
        p2.x=5.0;
        p2.y=6.0;
        System.out.println(p1.distance(p2));
        
    }
}