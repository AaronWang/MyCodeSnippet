package jaxb.example1;

import java.util.ArrayList;
import java.util.List;

import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement(name = "MUSEUMS")
public class Museums {

	List<Museum> museums;

	public void setMuseums(List<Museum> museums) {
		this.museums = museums;
	}

	@XmlElement(name = "MUSEUM")
	public List<Museum> getMuseums() {
		return museums;
	}

	public void add(Museum museum) {
		if (this.museums == null) {
			this.museums = new ArrayList<Museum>();
		}
		this.museums.add(museum);
	}
}