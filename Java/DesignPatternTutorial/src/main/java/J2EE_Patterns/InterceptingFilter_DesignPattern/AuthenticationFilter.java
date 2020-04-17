package J2EE_Patterns.InterceptingFilter_DesignPattern;

public class AuthenticationFilter implements Filter {
	public void execute(String request) {
		System.out.println("Authenticating request: " + request);
	}
}
