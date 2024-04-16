package _04_16_Generikusok.data.structure;

import java.util.HashMap;
import java.util.Map.Entry;

public class MultiSet<E>{
    private HashMap<E, Integer> elemToCount;

    public MultiSet(){
        elemToCount = new HashMap<>();        
    }

    public MultiSet(E[] arr){
        elemToCount = new HashMap<>();
        for (E elem : arr){
            this.add(elem);
        }
    }

    public int add(E par){
        if (elemToCount.containsKey(par)){
            elemToCount.replace(par,elemToCount.get(par)+1);
        } else{
            elemToCount.put(par,1);
        }
        return 0;
    }

    public int getCount(E par){
        if(elemToCount.containsKey(par)){
            return elemToCount.get(par);
        }
        return 0;
    }

    public MultiSet<E> intersect(MultiSet<E> otherMultiSet){
        MultiSet<E> resultBag = new MultiSet<>();
        for(Entry<E,Integer> entry :  elemToCount.entrySet()){
            if(otherMultiSet.getCount(entry.getKey())>0){
                resultBag.elemToCount.put(entry.getKey(),Math.min(entry.getValue(),otherMultiSet.elemToCount.get(entry.getKey())));
            }
        }
        return resultBag;
    }

    public int size(){
        return 0;
    }

    //vararg of T: azonos T tipusu parameterbol lehet 0 vagy tobb = T...
    //Textual representation: @Overload annotacio
    //Jovo heten nincs ora!
}