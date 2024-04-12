package _03_26_IO_exception.text.to.numbers;

import static check.CheckThat.*;
import static check.CheckThat.Condition.*;
import org.junit.jupiter.api.*;
import check.CheckThat;

public class MultiLineFileStructureTest {
    @BeforeAll
    public static void init() {
        CheckThat.theClass("_03_26_IO_exception.text.to.numbers.MultiLineFile")
            .thatIs(FULLY_IMPLEMENTED, INSTANCE_LEVEL, VISIBLE_TO_ALL);
    }

    @Test
    public void constructor() {
        it.has(DEFAULT_CONSTRUCTOR);
    }

    @Test
    public void methodAddNumbers() {
        it.hasMethod("addNumbers", withParams("String", "char"))
            .thatIs(FULLY_IMPLEMENTED, USABLE_WITHOUT_INSTANCE, VISIBLE_TO_ALL)
            .thatReturns("int");
    }
}

