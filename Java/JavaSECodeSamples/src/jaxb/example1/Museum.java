package jaxb.example1;

import javax.xml.bind.annotation.XmlAttribute;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;

@XmlType(propOrder = { "name", "city", "permanent", "special" })
@XmlRootElement(name = "MUSEUM")
public class Museum {

	String name;

	String city;

	Exhibition permanent;

	Exhibition special;

	public void setName(String name) {
		this.name = name;
	}

	Boolean childrenAllowed;

	public void setChildrenAllowed(Boolean childrenAllowed) {
		this.childrenAllowed = childrenAllowed;
	}

	@XmlElement(name = "CITY")
	public String getCity() {
		return city;
	}

	public void setCity(String city) {
		this.city = city;
	}

	@XmlElement(name = "MUSEUM_NAME")
	public String getName() {
		return name;
	}

	@XmlAttribute(name = "children_allowed")
	public Boolean getChildrenAllowed() {
		return childrenAllowed;
	}

	@XmlElement(name = "PERMANENT_EXHIBITION")
	public Exhibition getPermanent() {
		return permanent;
	}

	public void setPermanent(Exhibition permanent) {
		this.permanent = permanent;
	}

	@XmlElement(name = "SPECIAL_EXHIBITION")
	public Exhibition getSpecial() {
		return special;
	}

	public void setSpecial(Exhibition special) {
		this.special = special;
	}

}