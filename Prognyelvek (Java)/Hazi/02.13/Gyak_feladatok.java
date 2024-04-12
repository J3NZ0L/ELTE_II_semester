public class Gyak_feladatok{

    public static void main( String[] args){
        //1. gyakf
        //int n=Integer.parseInt(System.console().readLine());
        /*
        if (args.length==1){
            int n=Integer.parseInt(args[0]);
            float s=0;
            for (float i=0; i<=n; i++){
                if (n%i==0){
                    s+=i;
                }
            }  
            if (n==(int)(s/2)){
                System.out.printf("A szam tokeletes.");    
            } else {
                System.out.printf("A szam nem tokeletes.");    
            }
        } else {
            System.out.printf("Nem jo argumentumszam");
        }
        */
    //    2. feladat

       /*
        if (args.length==1){
            int sum=0;
            int n=Integer.parseInt(args[0]);
            for (int j=0; j<n; j++){
                float s=0;
                for (float i=0; i<=n; i++){
                    if (j%i==0){
                        s+=i;
                    }
                }  
                if (j==(int)(s/2)){
                    sum+=1;
                }
            }
            System.out.println("Tokeletes szamok szama az intervallumban: "+sum);
        } else {
            System.out.printf("Nem jo argumentumszam");
        }
        */
        //3. feladat
        /*
        if (args.length>=1){
            long elso=Long.parseLong(args[0]);
            long kovi=0;
            long tmp;
            for (int i=2; i<=args.length; i++){
                kovi=Long.parseLong(args[i-1]);
                while (elso%kovi!=0){
                    tmp=elso;
                    elso=kovi;
                    kovi=tmp%elso;
                }
                elso=kovi;
            }
            System.out.println(kovi);
        } else {
            System.out.println("Nem megfelelo argumentumszam");
        }
        */
        //4. feladat
        /*
        System.out.println("Kerek egy szamot: ");
        int szam=Integer.parseInt(System.console().readLine());
        System.out.println("Kerek egy pontossagot: ");
        double pontossag=Double.parseDouble(System.console().readLine());
        double xp=(double)szam/2;
        double xs= (xp+(double)szam/xp)/2;
        double tmp;
        System.out.println(xp-xs);
        while (Math.abs(xp-xs)>pontossag){
            xp=xs;
            xs=(xs+(double)szam/xs)/2;
            System.out.println(xs);
        }
        System.out.println("A szam negyzetgyoke: ");
        System.out.println(xs);
        */
       
    }
}