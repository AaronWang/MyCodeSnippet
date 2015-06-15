
import junittest.TestJunit1;
import junittest.TestJunit2;
import junittest.TestJunit3;

import org.junit.runner.RunWith;
import org.junit.runners.Suite;

@RunWith(Suite.class)
@Suite.SuiteClasses({
    TestJunit1.class,
    TestJunit2.class,
    TestJunit3.class
})

public class JunitTestSuite {
//	System.out.println("abcd....");
}
