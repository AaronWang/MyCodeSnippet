package Behavioral_Patterns.ChainofResponsibility_DesignPattern;

public class FileLogger extends AbstractLogger {
	public FileLogger(int level) {
		this.level = level;
	}

	@Override
	protected void write(String message) {
		System.out.println("FileLogger File::Logger: " + message);
	}
}
