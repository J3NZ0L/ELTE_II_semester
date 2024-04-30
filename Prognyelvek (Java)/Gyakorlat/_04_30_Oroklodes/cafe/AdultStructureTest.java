package _04_30_Oroklodes.cafe;

import static check.CheckThat.*;
import static check.CheckThat.Condition.*;
import org.junit.jupiter.api.*;
import check.CheckThat;

public class AdultStructureTest {
    @BeforeAll
    public static void init() {
        CheckThat.theClass("_04_30_Oroklodes.cafe.Adult", withParent("_04_30_Oroklodes.cafe.Guest"))
            .thatIs(FULLY_IMPLEMENTED, INSTANCE_LEVEL, VISIBLE_TO_ALL);
    }

    @Test
    public void constructor() {
        it.hasConstructor(withArgs("String", "int"))
            .thatIs(VISIBLE_TO_ALL);
    }
}

