package jaxb.example2;

import java.io.File;

import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import javax.xml.bind.Marshaller;
import javax.xml.bind.Unmarshaller;

public class JAXBExample {
	public static void main(String[] args) {

		// Convert Object to XML
		Customer customer = new Customer();
		customer.setId(100);
		customer.setName("mkyong");
		customer.setAge(29);

		try {

			File file = new File("file.xml");
			JAXBContext jaxbContext = JAXBContext.newInstance(Customer.class);
			Marshaller jaxbMarshaller = jaxbContext.createMarshaller();

			// output pretty printed
			jaxbMarshaller.setProperty(Marshaller.JAXB_FORMATTED_OUTPUT, true);

			jaxbMarshaller.marshal(customer, file);
			jaxbMarshaller.marshal(customer, System.out);

		} catch (JAXBException e) {
			e.printStackTrace();
		}
		System.out.println("---------------------------------------------");
		// Convert XML to Object
		try {

			File file = new File("file.xml");
			JAXBContext jaxbContext = JAXBContext.newInstance(Customer.class);

			Unmarshaller jaxbUnmarshaller = jaxbContext.createUnmarshaller();
			Customer customer1 = (Customer) jaxbUnmarshaller.unmarshal(file);
			System.out.println(customer1);
			System.out.println(customer1.getAge());
			System.out.println(customer1.getName());

		} catch (JAXBException e) {
			e.printStackTrace();
		}

	}
}