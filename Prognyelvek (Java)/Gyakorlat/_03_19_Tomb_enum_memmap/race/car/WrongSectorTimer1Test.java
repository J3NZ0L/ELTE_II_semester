package _03_19_Tomb_enum_memmap.race.car;

import static check.CheckThat.*;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.*;
import org.junit.jupiter.api.condition.*;
import org.junit.jupiter.api.extension.*;
import org.junit.jupiter.params.*;
import org.junit.jupiter.params.provider.*;
import check.*;

public class WrongSectorTimer1Test{
    private WrongSectorTimer1 sectorTimer1;
    public int[] arr;
    @BeforeEach
    public void beforeTests(){
        arr=new int[]{1,2,3};
        sectorTimer1= new WrongSectorTimer1(arr);
    }

    @Test
    public void seemsGood(){
        assertArrayEquals(arr,sectorTimer1.sectorTimes);
    }

    @Test
    public void setArrayElemsBreakEncapsulation(){
        sectorTimer1.sectorTimes[0]=3;
        sectorTimer1.sectorTimes[1]=5;
        sectorTimer1.sectorTimes[2]=8;
        assertEquals(3,sectorTimer1.sectorTimes[0]);
        assertEquals(5,sectorTimer1.sectorTimes[1]);
        assertEquals(8,sectorTimer1.sectorTimes[2]);
    }

    @Test
    public void setArrayElemsBreakEncapsulation2(){
        int[] newArr= new int[]{4,5,6,7};
        sectorTimer1.sectorTimes=newArr;
        assertArrayEquals(newArr,sectorTimer1.sectorTimes);
    }
}