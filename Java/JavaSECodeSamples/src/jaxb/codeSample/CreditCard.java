package jaxb.codeSample;

import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement
public class CreditCard {
	private String number;
	private String expiryDate;
	private Integer controlNumber;
	private String type;

	// must have default Constructors, getters, setters for all variables;
	// all variables will be in XML document;
	//all methods and variables will be included in XML document;if variable is public, it can't have getter and setter;
	
	public CreditCard(String number, String expiryDate, Integer controlNumber, String type) {
		super();
		this.number = number;
		this.expiryDate = expiryDate;
		this.controlNumber = controlNumber;
		this.type = type;
	}

	public CreditCard() {
		super();
		// TODO Auto-generated constructor stub
	}

	public String getNumber() {
		return number;
	}

	public void setNumber(String number) {
		this.number = number;
	}

	public String getExpiryDate() {
		return expiryDate;
	}

	public void setExpiryDate(String expiryDate) {
		this.expiryDate = expiryDate;
	}

	public Integer getControlNumber() {
		return controlNumber;
	}

	public void setControlNumber(Integer controlNumber) {
		this.controlNumber = controlNumber;
	}

	public String getType() {
		return type;
	}

	public void setType(String type) {
		this.type = type;
	}

}
