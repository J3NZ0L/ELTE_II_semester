package _04_30_Oroklodes;

import _04_30_Oroklodes.cafe.Adult;
import _04_30_Oroklodes.cafe.Bartender;
import _04_30_Oroklodes.cafe.Guest;
import _04_30_Oroklodes.cafe.Minor;

import static check.CheckThat.*;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.*;
import org.junit.jupiter.api.condition.*;
import org.junit.jupiter.api.extension.*;
import org.junit.jupiter.params.*;
import org.junit.jupiter.params.provider.*;
import check.*;

public class CafeTest{
    private static Bartender b= new Bartender( 18);;
    @Test
    public void testAdult(){
        Guest go = new Adult("Alice", 20);
        Guest gy = new Adult("Adolf", 12);
        assertTrue(b.order(go));
        assertTrue(b.order(gy));
    }
    @Test
    public void testMinor(){
        Guest gy = new Minor("Bob", 17);
        Guest go = new Minor("Bob", 33);
        assertFalse(b.order(gy));
        assertTrue(b.order(go));

    }

}