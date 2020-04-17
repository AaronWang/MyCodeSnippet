package J2EE_Patterns.InterceptingFilter_DesignPattern;

public class DebugFilter implements Filter {
	public void execute(String request) {
		System.out.println("Debuge: request log: " + request);
	}
}
