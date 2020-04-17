package J2EE_Patterns.InterceptingFilter_DesignPattern;

public class Target {
	public void execute(String request) {
		System.out.println("Executing request: " + request);
	}
}
