package J2EE_Patterns.ServiceLocator_DesignPattern;

public class Service2 implements Service {
	public void execute() {
		System.out.println("Executing Service2");
	}

	@Override
	public String getName() {
		return "Service2";
	}
}
