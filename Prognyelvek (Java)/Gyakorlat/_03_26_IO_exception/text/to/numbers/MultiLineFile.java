package _03_26_IO_exception.text.to.numbers;
/* 
A MultiLineFileStructureTest alapján írjuk meg az text.to.numbers.MultiLineFile.addNumbers() metódust. Ez a fájl összes sorában található, összes szám összegét adja meg. Ennek legyen még egy paramétere, az elválasztójel karaktere.

Ezt is teszteljük. Az előzőhöz képest különbség: üres fájl esetén nem váltódik ki kivétel. Az érvényes fájlt teszteljük szóköz és vessző elválasztójellel egyaránt.
*/
import java.io.*;
import java.util.Scanner;

public class MultiLineFile{
    public static int addNumbers(String filename, String delim) throws IOException{
        File input = new File(filename);

        Scanner scanline = new Scanner ( input).useDelimiter(delim);
        Scanner sc = null;
        
        String line;
        int sum = 0; // akt sor szummaja
        try{
            if ( scanline.hasNextLine()){//megnezi h van e meg adat
                line = scanline.nextLine(); // o is dob kivetelt egyebkent
            } else {
                throw new IllegalArgumentException("Empty file");
            }
            sc = new Scanner(line);
            while ( sc.hasNext()){
                if ( sc.hasNextInt()){
                    sum+=sc.nextInt(); 
                } else {
                    String message = "Not a number: " +sc.next();
                    System.err.println(message);
                }
            }
        }catch( IllegalArgumentException e){ //csak azert tesszuk try catchbe h atlathatobb legyen
            
            System.out.println("Exception: "+e);
        }finally{ //garantaljuk h try utan ide belepunk
            scanline.close();
            if ( sc!=null){
                sc.close();
            }
            System.out.println("Streams have been closed successfully!");
        }
        return sum;
    }
}