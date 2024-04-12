package _03_26_IO_exception.demo;

import java.io.*; //Ez a konyvtar kell barmilyen fajlbol olvasashohz illletve irashoz

public class ReadWrite{
    public static String readFromStandardInput() throws IOException{ //normal konzolos beolvasas normal csatolasi eszkozokkel
    //itt nem kezeljuk, hanem feljebb dobjuk a kivetelt, ott majd vagy tovabbdobodik vagy egy try-catch blokk kezeli
        //mindig fennall az eselye h a csatorna vmi miatt nem elerheto
            //ellenorzott kivetel, IO exception keletkezhet a  metodus hivasok soran
            //ezekkel foglalkozni kell, vagy kivaltas pillanataban kell elkapni vvagy tovabb kell adni
            //folyamatos monitorozas kell, 

        BufferedReader br = new BufferedReader( new InputStreamReader(System.in)); //system.in a csatorna, ebbol kene valami ertelmezhetot kiszedni
        // kelll egy olvaso ami ezt a csatornat olvasni tudja, ez lesz az ISR, ez beolvassa a binaris jeleket es visszaadja karakterek formajaban, (ISR csak letezo csatornat tud kezelni)
        //kovetkezo: pufferelo, fogom a csatornat, elkezdjuk kigyujteni amig tudjuk ertelmezni, akkor allunk meg ha eleg adat osszegyult vagy nincs tobb adat a csatornaban: ez lesz a BR
            //olyan mint amikor bemegyunk a terembe, ISR nelkul allandoan nyyitogatni kene az ajtot, BR segitsegevel egyszer nyitjuk, mindenki bejon aztan becsukjuk
            //olyan formaban adja vissza amivel kenyelmes dolgozni
        return br.readLine();//ezzel tuduunk kiolvasni egy sort errol a csatornarol, ez egy alapfelallas
    }

    public static void readFromFile(String source) throws IOException{//source: eleresi utvonal
        BufferedReader br = new BufferedReader( new FileReader(source)); //ISR helyett FR, megkapja a sorcet, megkeresi, mmegnyitja, BR miatt soros olvasas is lehetove valik, innentol kezdve ugyanolyan a br nintha std bemenetrol olvasnank
        String line;
        while((line=br.readLine())!= null){ //null akkor lesz ha nincs mar mit beolvasni
            System.out.println(line);
        }
        System.out.println(line);
        br.close(); // mindig be is kell azrni a csatornat amit megnyitottunk, ezt ISR-nel azert nem kell mert az konzol, es mashogy mukodik mint egy fajl, a konzolt nem mi nyitjuk meg, ott a kulccsatortnat nyitjuk meg amivel elerjuk a konzolt, bar egyebkent be lehet zarni csak nem biztos h kell, es ha esetleg utana mmegis kene akkor az oprendszer utana nem ad mar jogot arra h ujra megnyissuk, a program futasa alatt, szoval nem szukseges bezarni
    } 

    public static void writeToFile(String[] data, String destination) throws IOException { //fajlbairo
        PrintWriter pw = new PrintWriter(new BufferedWriter(new FileWriter(destination, true))); //masodik argumentuma h append vagy feluliras, true az append, amugy elhagyhato es akkor append az alapert.
            //PW azert kell h kenyelmesen formazott szoveget tudjunk irni a fajlba, igy olyan lesz mintha terminalra dolgoznank
        for(String d : data){
            pw.println(d);
        }
        pw.close(); // itt is le kell zarni a fajlt
    }

    public static void main(String[] args){
        String[] strs = new String[3];
        String sourceFile = "_03_26_IO_exception/source.txt";
        String destFile = "_03_26_IO_exception/demo/result.txt";
        try {
            System.out.println("Read from console");
            for ( int i=0;i<strs.length; i++ ){
                System.out.println((i+1)+" / "+strs.length+": ");
                strs[i] = readFromStandardInput();
            }
            System.out.println("Write to file");
            writeToFile(strs,destFile);
            System.out.println("Read from file");
            readFromFile(sourceFile);
        }
        catch( IOException e){
            System.out.println("An exception occorred!\n"+e.getMessage());
        }
    }

}