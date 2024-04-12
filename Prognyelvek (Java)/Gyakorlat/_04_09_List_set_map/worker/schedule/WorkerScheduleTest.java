package _04_09_List_set_map.worker.schedule;

import static check.CheckThat.*;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.*;
import org.junit.jupiter.api.condition.*;
import org.junit.jupiter.api.extension.*;
import org.junit.jupiter.params.*;
import org.junit.jupiter.params.provider.*;
import check.*;

import java.util.*;

public class WorkerScheduleTest{
    @Test
    public void emptySchedule(){
        WorkerSchedule ws = new WorkerSchedule();
        assertTrue( ws.emptySchedule());
        assertFalse(!ws.emptySchedule());
    }

    @Test
    public void getWorkWeeksTest(){
        WorkerSchedule ws = new WorkerSchedule();
        ws.add(1,new HashSet<>(Arrays.asList("John", "Jack", "Jill", "Judy")));
        ws.add(2,new HashSet<>(List.of("John", "Joe", "Jill", "Judy")));
        assertTrue(ws.isWorkingOnWeek("John",1));
        assertFalse(ws.isWorkingOnWeek("Jack",2));
        assertFalse(ws.isWorkingOnWeek("Jill",3));
        assertFalse(ws.isWorkingOnWeek("Mary",2));
        assertTrue(ws.isWorkingOnWeek("Judy",2));
    }

    @Test
    public void getWorkTest(){
        WorkerSchedule ws = new WorkerSchedule();
        ws.add(new HashSet<>(Arrays.asList(1,2,3)),new ArrayList<>(Arrays.asList("John", "Jack")));
        ws.add(new HashSet<>(Arrays.asList(2,3,4)),new ArrayList<>(List.of("John", "Mark", "Mary")));
        HashSet<Integer> weeksJohnWorks = ws.getWorkWeeks("John");
        HashSet<Integer> weeksMarkWorks = ws.getWorkWeeks("Mark");

        System.out.println(weeksJohnWorks);
        System.out.println(weeksMarkWorks);

        assertTrue(ws.isWorkingOnWeek("John",1));
        assertFalse(ws.isWorkingOnWeek("Jack",4));
        assertFalse(ws.isWorkingOnWeek("Jill",3));
        assertFalse(ws.isWorkingOnWeek("Jack",4));
        assertFalse(ws.isWorkingOnWeek("Judy",2));

        int[] expected = new int[]{1,2,3,4};
        for(int i=0; i<weeksJohnWorks.size(); i++){
            assertTrue(weeksJohnWorks.contains(expected[i]));
        }
        for(int i=1; i<weeksMarkWorks.size(); i++){
            assertTrue(weeksMarkWorks.contains(expected[i]));
        }
    }
}
// HF tobbi feladat string osztaly!