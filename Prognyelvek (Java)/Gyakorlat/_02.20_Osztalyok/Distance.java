public class Distance{
    public static void main(String[] args){
        int l =(int)(args.length/2);
        Point[] pontok= new Point[l];
        for (int i=0; i<pontok.length; i++){
            pontok[i]=new Point();
        }
        
        for (int i=0; i<l;i++){
            pontok[i].x=Double.parseDouble(args[2*(i)]);            
            pontok[i].y=Double.parseDouble(args[2*(i)+1]);            
        }
        
        double sum=0;
        for (int i=0; i<l-1; i++){
            sum+=pontok[i].distance(pontok[i+1]);;
        }
        System.out.println("sum: "+sum);
    }
}