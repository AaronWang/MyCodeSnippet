package J2EE_Patterns.BusinessDelegate_DesignPattern;

public class JMSService implements BusinessService {
	@Override
	public void doProcessing() {
		System.out.println("Processing task by invoking JMS Service");
	}
}
