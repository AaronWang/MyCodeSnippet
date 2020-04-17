package com.vaannila.admin;

import org.apache.log4j.Logger;
import com.vaannila.report.SampleReport;

public class SampleAdmin {

	static Logger logger = Logger.getLogger(SampleAdmin.class);

	public static void main(String[] args) {
//		PropertyConfigurator.configure("log4j.properties");
		logger.debug("Sample debug message");
		logger.info("Sample info message");
		logger.warn("Sample warn message");
		logger.error("Sample error message");
		logger.fatal("Sample fatal message");
		SampleReport obj = new SampleReport();
		obj.generateReport();
	}
}
