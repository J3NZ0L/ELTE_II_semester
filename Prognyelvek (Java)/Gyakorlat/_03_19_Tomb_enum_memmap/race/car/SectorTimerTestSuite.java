package _03_19_Tomb_enum_memmap.race.car;

import org.junit.platform.suite.api.SelectClasses;
import org.junit.platform.suite.api.Suite;
/*
import _03_19_Tomb_enum_memmap.race.car.SectorTimerTest;
import _03_19_Tomb_enum_memmap.race.car.WrongSectorTimer1Test;
import _03_19_Tomb_enum_memmap.race.car.WrongSectorTimer2Test;
*/
@Suite
@SelectClasses({
	WrongSectorTimer1StructureTest.class,
//	WrongSectorTimer1Test.class,

	WrongSectorTimer2StructureTest.class,
//	WrongSectorTimer2Test.class,

	SectorTimerStructureTest.class,
//	SectorTimerTest.class
})
public class SectorTimerTestSuite {}
