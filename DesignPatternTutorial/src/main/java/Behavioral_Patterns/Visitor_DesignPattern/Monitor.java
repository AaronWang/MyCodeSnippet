package Behavioral_Patterns.Visitor_DesignPattern;

public class Monitor implements ComputerPart {
	
	@Override
	public void accept(ComputerPartVisitor computerPartVisitor) {
		computerPartVisitor.visit(this);
	}
}
