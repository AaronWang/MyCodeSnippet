package jaxb.example1;

import java.io.File;
import java.time.LocalDate;
import java.time.Month;
import java.util.ArrayList;
import java.util.List;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;

public class MuseumJaxBExampleComplete {

	public static void main(String[] args) {
		try {

			Museum reinaSofia = new Museum();
			reinaSofia.setName("Reina Sofia Museum");
			reinaSofia.setCity("Madrid");
			Exhibition permanent = new Exhibition();
			permanent.setName("Permanent Exhibition - Reina Sofia Museum");
			permanent.setFrom(LocalDate.of(1900, Month.JANUARY, 1));
			permanent.setTo(LocalDate.of(2014, Month.DECEMBER, 31));
			List artistsReinaSofia = new ArrayList();
			artistsReinaSofia.add("Picasso");
			artistsReinaSofia.add("Dali");
			artistsReinaSofia.add("Miro");
			permanent.setArtists(artistsReinaSofia);
			reinaSofia.setPermanent(permanent);

			Museum prado = new Museum();
			prado.setName("Prado Museum");
			prado.setCity("Madrid");
			Exhibition permanentPrado = new Exhibition();
			permanentPrado.setName("Permanent Exhibition - Prado Museum");
			permanentPrado.setFrom(LocalDate.of(1500, Month.JANUARY, 1));
			permanentPrado.setTo(LocalDate.of(2000, Month.DECEMBER, 31));
			List artistsPrado = new ArrayList();
			artistsPrado.add("Velazquez");
			artistsPrado.add("Goya");
			artistsPrado.add("Zurbaran");
			artistsPrado.add("Tiziano");
			permanentPrado.setArtists(artistsPrado);
			prado.setPermanent(permanentPrado);

			Exhibition special = new Exhibition();
			special.setName("Game of Bowls (1908), by Henri Matisse");
			special.setFrom(LocalDate.of(1908, Month.JANUARY, 1));
			special.setTo(LocalDate.of(1908, Month.DECEMBER, 31));
			List artistsSpecial = new ArrayList();
			artistsSpecial.add("Mattise");
			special.setArtists(artistsSpecial);
			prado.setSpecial(special);

			Museums museums = new Museums();
			museums.add(prado);
			museums.add(reinaSofia);

			JAXBContext jaxbContext = JAXBContext.newInstance(Museums.class);
			Marshaller jaxbMarshaller = jaxbContext.createMarshaller();

			jaxbMarshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);

			jaxbMarshaller.marshal(museums, new File("museums.xml"));
			jaxbMarshaller.marshal(museums, System.out);

		} catch (JAXBException e) {
			e.printStackTrace();
		}

	}
}