package J2EE_Patterns.BusinessDelegate_DesignPattern;

public class EJBService implements BusinessService {
	@Override
	public void doProcessing() {
		System.out.println("Processing task by invoking EJB Service");
	}
}
