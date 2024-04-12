package _04_09_List_set_map.worker.schedule;

/*
Adatszerkezetekrol par szo
array list: tomb, de futasi idoben valtozo meretu tomb, hatrany: heapen dolgozik, primitiv ertekeket nem tud tarolni csak objektumokat, ezert be kell csomagolni majd a primitiv ertekeket a megfelelo objektumokba

set: halmaz, nincs benne ismetlodo elemek ( csak egyedi elemek, ha ugyanazt raknank bele akkor felulirodik a regi)

hashmap: kulcs-ertekpar tarolasi modszer, gyakorlatilag egy tomb aminek az indexet mi allithatjuk be, szoval itt az egyedi kulcsokat mi allithatjuk be
*/

import java.util.HashMap;
import java.util.HashSet;
import java.util.ArrayList;
import java.util.Map.Entry;

public class WorkerSchedule{
    private HashMap<Integer,HashSet<String>> weekToWorkers = new HashMap<>(); //diamond (<>) ha tudjuk h mi a referencia  akkor az ures konstruktorbol tudni fogja a fordito h milyen tipust kell letrehozni, de az se baj ha kiirja az ember a teljes tipust mint baloldalt
    //a masodik teszt ami a konstruktorra vonatkozik felesleges igazabol

    //1-52 munkahetekkel dolgozunk, tfh. az adatok eszerint helyesek lesznek
    public void add(int week, HashSet<String> newworkers ){
        week--; //0-51-es indexelesre atteres
        if(!weekToWorkers.containsKey(week)){
            weekToWorkers.put(week, new HashSet<String>());
        }
        HashSet<String> workers = weekToWorkers.get(week); //lehet egybe ugy, hogy 
        // weekToWorkers.get(week).addAll(newworkers);
        for(String worker : newworkers){
            workers.add(worker);
        } //erre egyszerubb megoldas:
        //workers.addAll(newworkers); //tipusoknak egyeznie kell, de a ket adatszerkezetnek nem kell feltetlen egyeznie

    }

    public void add(HashSet<Integer> weeks, ArrayList<String> newworkers){
        HashSet<String> nws = new HashSet<>();
        nws.addAll(newworkers);
        for( Integer week : weeks){
            add(week, nws); // a sajat elozo add metodus
        }
    }

    public boolean isWorkingOnWeek(String worker, int week){
        week--;
        if(!weekToWorkers.containsKey(week)){
            return false;
        }
        return weekToWorkers.get(week).contains(worker);
    }

    public HashSet<Integer> getWorkWeeks(String worker){
        HashSet<Integer> assignment = new HashSet<>();
        for( Entry<Integer, HashSet<String>> entry : weekToWorkers.entrySet()){ //bejegyzeskent tekinti a kulcs-ertekparokat){ //kulcs-ertekpart egy objektumkent elerhetove teszi az Entry tipus
            Integer week = entry.getKey() + 1;
            if (isWorkingOnWeek(worker, week)){
                assignment.add(week);
            }

        }
        return assignment;
    }

    public boolean emptySchedule(){
        return weekToWorkers.isEmpty(); //beepitett fuggveny, megnezi h null-e a hivatkozas
    }


}