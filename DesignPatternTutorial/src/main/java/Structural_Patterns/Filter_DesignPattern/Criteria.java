package Structural_Patterns.Filter_DesignPattern;

import java.util.List;

public interface Criteria {
	public List<Person> meetCriteria(List<Person> persons);
}
