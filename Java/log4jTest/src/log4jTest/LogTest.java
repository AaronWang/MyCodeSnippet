package log4jTest;

import org.apache.log4j.Logger;

public class LogTest
{
	private static org.apache.log4j.Logger log = Logger.getLogger(LogTest.class);

	public static void main(String[] args)
	{

		// TODO Auto-generated method stub
//		BasicConfigurator.configure();
		log.trace("Trace Message!");
		log.debug("Debug Message!");
		log.info("Info Message!");
		log.warn("Warn Message!");
		log.error("Error Message!");
		log.fatal("Fatal Message!");
	}

}



