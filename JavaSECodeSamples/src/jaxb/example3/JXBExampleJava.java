package jaxb.example3;

import java.io.File;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import javax.xml.bind.Unmarshaller;

public class JXBExampleJava {

	private static final String xmlFilePath = "Student.xml";

	public static void main(String[] args) {

		try {
			Student student = new Student("James", "Jonathan", 25, 100);
			File xmlfile = new File(xmlFilePath);
			JAXBContext jaxbContext = JAXBContext.newInstance(Student.class);
			Marshaller jaxbMarshaller = jaxbContext.createMarshaller();

			// print the output with nice alignment
			jaxbMarshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);

			jaxbMarshaller.marshal(student, xmlfile);

			// you can use this to print the result in
			// standard output for debugging purposes
			// jaxbMarshaller.marshal(student, System.out);

			System.out.println("File was created succesfully");

		} catch (JAXBException e) {
			e.printStackTrace();
		}

		try {

			File xmlFile = new File(xmlFilePath);
			JAXBContext jaxbContext = JAXBContext.newInstance(Student.class);

			Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();
			Student student = (Student) jaxbUnmarshaller.unmarshal(xmlFile);
			System.out.println(student);

		} catch (JAXBException e) {
			e.printStackTrace();
		}

	}
}