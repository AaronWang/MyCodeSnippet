package com.javacodegeeks.examples.rivu.jpa.service;

import java.util.Iterator;
import java.util.List;
import java.util.Scanner;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

import com.javacodegeeks.examples.rivu.jpa.entity.Employee;
import com.javacodegeeks.examples.rivu.jpa.entity.Department;
import com.javacodegeeks.examples.rivu.jpa.entity.Employee;
import com.javacodegeeks.examples.rivu.jpa.entity.Projects;

public class OnetoManyService {

    public static void main(String[] args) {
        // TODO Auto-generated method stub

        Scanner sc = new Scanner(System.in);

        EntityManagerFactory emfactory = Persistence.createEntityManagerFactory("DerbyJPA");
        EntityManager entitymanager = emfactory.createEntityManager();
        entitymanager.getTransaction().begin();

        System.out.println("Enter Employee ID");

        int eid = sc.nextInt();

        Employee emp = entitymanager.find(Employee.class, eid);

        System.out.println("Employee: " + emp.toString());
        List projects = emp.getProjects();

        Iterator ps = projects.iterator();

        int count = 0;

        while (ps.hasNext()) {
            System.out.println("Project " + (++count) + " : " + ps.next().toString());
        }

        entitymanager.getTransaction().commit();

        entitymanager.close();
        emfactory.close();

    }

}
