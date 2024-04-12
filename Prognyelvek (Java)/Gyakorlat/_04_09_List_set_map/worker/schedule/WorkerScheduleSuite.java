package _04_09_List_set_map.worker.schedule;

import org.junit.platform.suite.api.SelectClasses;
import org.junit.platform.suite.api.Suite;

import _04_09_List_set_map.worker.schedule.WorkerScheduleTest;

@Suite
@SelectClasses({
    WorkerScheduleStructureTest.class
    , WorkerScheduleTest.class
})
public class WorkerScheduleSuite {}
