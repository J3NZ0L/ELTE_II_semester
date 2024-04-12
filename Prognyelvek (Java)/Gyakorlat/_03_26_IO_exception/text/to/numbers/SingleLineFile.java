/*                      //DB7ZTC

A SingleLineFileStructureTest alapján írjuk meg a text.to.numbers.SingleLineFile.addNumbers() metódust, ami egy fájlnevet vesz át, és az első sorában található számok összegével tér vissza.

Ha nem létezik a fájl, az IOException kivétel terjedjen ki a metóduson kívülre.
Ha a fájl üres, váltsunk ki IllegalArgumentException kivételt Empty file üzenettel.
A fájl első sorának minden olyan szavát, ami nem értelmezhető int értékként, írjuk ki a System.err hibafolyamra. Erre ugyanúgy lehet írni, mint a System.out folyamra.
A fájl használatának a végén erőforráskezelő try eszközzel garantáljuk a fájl bezárását.
Készítsük el az alábbi teszteseteket.

A két kivételes eset tesztelése.
A tesztelő metódus egyszerűen kapja el a kivételeket.
Ha mégse váltódna ki kivétel, hívjuk meg a fail() metódust. Ez kaphat egy hibaüzenetet is.
A második esetben a kivétel szövege így kérhető le: e.getMessage().
Mj.: a JUnit assertThrows() metódusával még elegánsabb megoldás adható, de ez egy haladóbb szintű eszköz, nem célunk használni.
Egy érvényes fájl tesztelése, melynek első sora 1 2 not text 3 -123 tartalmú.
A kimenetre kiírt szövegeket nem teszteljük JUnit segítségével, de ott kell lenniük.
Mj.: a fentiek nem valódi egységtesztek, mert a fájlrendszert is használják.
*/
package _03_26_IO_exception.text.to.numbers;
import java.io.*;
import java.util.Scanner;

public class SingleLineFile{
    public SingleLineFile(){}
    public static int addNumbers(String file) throws IOException{
        File input = new File(file);

        Scanner scanline = new Scanner ( input);
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