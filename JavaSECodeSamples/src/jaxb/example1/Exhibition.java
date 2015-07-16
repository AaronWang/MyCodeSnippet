package jaxb.example1;

import java.time.LocalDate;
import java.util.List;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;
import javax.xml.bind.annotation.adapters.XmlJavaTypeAdapter;

//@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(propOrder = { "name", "artists", "from", "to" })
@XmlRootElement(name = "PERMANENT_EXHIBITION")
public class Exhibition {

	String name;

	LocalDate from;

	LocalDate to;

	@XmlElement(name = "ARTIST")
	List<String> artists;

	@XmlElement(name = "NAME")
	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	@XmlJavaTypeAdapter(LocalDateAdapter.class)
	@XmlElement(name = "FROM")
	public LocalDate getFrom() {
		return from;
	}

	public void setFrom(LocalDate from) {
		this.from = from;
	}

	@XmlJavaTypeAdapter(LocalDateAdapter.class)
	@XmlElement(name = "TO")
	public LocalDate getTo() {
		return to;
	}

	public void setTo(LocalDate to) {
		this.to = to;
	}

	public List<String> getArtist() {
		return artists;
	}

	public void setArtists(List<String> artists) {
		this.artists = artists;
	}

}
