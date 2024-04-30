package _04_30_Oroklodes;

import org.junit.platform.suite.api.SelectClasses;
import org.junit.platform.suite.api.Suite;

import _04_30_Oroklodes.cafe.AdultStructureTest;
import _04_30_Oroklodes.cafe.BartenderStructureTest;
import _04_30_Oroklodes.cafe.GuestStructureTest;
import _04_30_Oroklodes.cafe.MinorStructureTest;

@Suite
@SelectClasses({
    BartenderStructureTest.class,
    GuestStructureTest.class,
    AdultStructureTest.class,
    MinorStructureTest.class
})
public class CafeSuite {}
