public class Orai_feladatok //DB7ZTC
{
    public static void main( String[] args){
        //3. feladat
        /*
        System.out.println("Neved: ");

        String nev=System.console().readLine();  
        System.console().printf("Szia "+nev);
        */
        //4. feladat
        /*
        if (args.length==1){
            System.out.println("Szia "+args[0]);
        } else {
            System.out.println("Nem adtal meg programhivasi argumentumkent nevet, vagy tul sok argumentumot adtal meg.");
        }
        */
        //5. feladat
        /*
        float n;
        int i;
        for( i = 1; i <= 4; i++) {
            n=i/2;
            System.out.println(n);
        }
        i=i-1;
        System.out.println("I displayed " + i + " numbers");
        */
       //6. feladat
       /*
        int a = Integer.parseInt(System.console().readLine());
        int b = Integer.parseInt(System.console().readLine());
        float n;
        for (int i=a+1; i<b; i++){
            n=i;
            System.out.println(n/2);
        }
        */
       //7. feladat
       /*
        System.out.println("Irjal be ket szamot kulon sorba:");
        int a = Integer.parseInt(System.console().readLine());
        int b = Integer.parseInt(System.console().readLine());
        System.out.println("Osszeg:"+(a+b));
        System.out.println("Kulonbseg:"+(a-b));
        System.out.println("Szorzat:"+(a*b));
        float bf=b;
        if (b==0){
            System.out.println("Hanyadosnal 0 lenne a nevezo");
        } else {
            System.out.println("Hanyados:"+(a/bf));
        };
        if (b==0){
            System.out.println("Maradeknal 0 lenne a nevezo");
        } else {
            System.out.println("Maradek:"+(a%b));
        };
        */
        //8. feladat
        /*
        System.out.println("N: ");
        int n = Integer.parseInt(System.console().readLine());
        int f=1;
        for (int i=n; i>0; i--){
            f=f*i;
        }
        System.out.println("N faktorialis: "+f);
        */       
    }

}