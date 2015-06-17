package Behavioral_Patterns.Visitor_DesignPattern;

public interface ComputerPart {
	public void accept(ComputerPartVisitor computerPartVisitor);
}
