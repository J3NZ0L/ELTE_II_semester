package _03_19_Tomb_enum_memmap.array.util;

import static check.CheckThat.*;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.*;
import org.junit.jupiter.api.condition.*;
import org.junit.jupiter.api.extension.*;
import org.junit.jupiter.params.*;
import org.junit.jupiter.params.provider.*;
import check.*;

public class ArrayUtilFunctionalTest{
    @Test
    public void maxLength0(){
        int[] array = {};
        assertEquals(0, ArrayUtil.max(array));
        assertEquals(0, ArrayUtil.max2(array));
        assertEquals(0, ArrayUtil.max3(array));
        assertEquals(0, ArrayUtil.max4(array));
    }

    @ParameterizedTest
    @CsvSource (textBlock = """
        0, 0
        1, 1
        2147483647, 2147483647
        -2147483648, -2147483648

    """)
    public void maxLength1(int expected, int n){
        int [] array = {n};
        assertEquals(expected, ArrayUtil.max(array));
        assertEquals(expected, ArrayUtil.max2(array));
        assertEquals(expected, ArrayUtil.max3(array));
        assertEquals(expected, ArrayUtil.max4(array));
    }

    @ParameterizedTest
    @CsvSource (textBlock = """
        0, 0, 0
        1, 0, 1
        1, 1, 0
        2147483647, 2147483647, 12000
        2147483647, -2147483648, 2147483647

    """)
    public void maxLength2(int expected, int min, int max){
        int [] array = {min, max};
        assertEquals(expected, ArrayUtil.max(array));
        assertEquals(expected, ArrayUtil.max2(array));
        assertEquals(expected, ArrayUtil.max3(array));
        assertEquals(expected, ArrayUtil.max4(array));
    }


    @Test
    public void minMaxLength0(){
        int [] array = {};
        int [] expectedArray = {0, 0};
        assertArrayEquals(expectedArray, ArrayUtil.minMax(array));
    }

    @ParameterizedTest
    @CsvSource (textBlock = """
        0, 0, 0,
        1, 1, 1
        2147483647, 2147483647, 2147483647
        -2147483647, -2147483647,  -2147483647
        
    """)
    public void minMaxLength1(int expectedmin, int expectedmax, int a){
        int [] expectedArray = {expectedmin, expectedmax};
        int [] array = {a};
        assertArrayEquals(expectedArray, ArrayUtil.minMax(array));
    }


    @ParameterizedTest
    @CsvSource (textBlock = """
        0, 0, 0, 0
        0, 1, 0, 1
        0, 1, 1, 0
        0, 2147483647, 2147483647, 0
        0, 2147483647, 0, 2147483647
        
    """)
    public void minMaxLength2(int expectedmin, int expectedmax, int a, int b){
        int [] expectedArray = {expectedmin, expectedmax};
        int [] array = {a, b};
        assertArrayEquals(expectedArray, ArrayUtil.minMax(array));
    }



}