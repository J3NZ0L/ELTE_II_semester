package _03_26_IO_exception.text.to.numbers;

import static check.CheckThat.*;
import static org.junit.jupiter.api.Assertions.*;
import org.junit.jupiter.api.*;
import org.junit.jupiter.api.condition.*;
import org.junit.jupiter.api.extension.*;
import org.junit.jupiter.params.*;
import org.junit.jupiter.params.provider.*;
import check.*;

import java.io.IOException;

public class SingleLineFileTest{
    @Test
    public void fileNotExist(){
        System.out.println("\n === fileNotExist Test ===");
        try {
            
            //SingleLineFile.addNumbers("_03_26_IO_exception/text/to/numbers/wrong.txt");
            SingleLineFile.addNumbers("_03_26_IO_exception/source.txt");
            fail("FAILED  fileNotExist test: Exception hasn't occured!"); //ha idaig elmegy a futas akkor gatya, biztos nem ok a teszt
            //hasznos cucc, lehet h ZH-n is kelleni fog!!!
        } catch ( IOException e ){
            System.out.println("File not exist test: OK!");
            System.out.println(e.getMessage());
        }
    }

    @Test
    public void validFileTest(){
        try{
            SingleLineFile.addNumbers("_03_26_IO_exception/validfile.txt");
        }   catch(IOException e){
            fail("Found valid file test: FAILED!");
        }    

    }
}