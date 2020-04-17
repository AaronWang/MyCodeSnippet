/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.javacodegeeks.examples.rivu.jpa.service;

import com.javacodegeeks.examples.rivu.jpa.entity.Employee;
import com.javacodegeeks.examples.rivu.jpa.entity.Job;
import java.util.Scanner;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

/**
 *
 * @author aaron
 */
public class OnetoOneService {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner sc = new Scanner(System.in);

        EntityManagerFactory emfactory = Persistence.createEntityManagerFactory("DerbyJPA");
        EntityManager entitymanager = emfactory.createEntityManager();
        entitymanager.getTransaction().begin();

        System.out.println("Enter Job ID");

        int jid = sc.nextInt();

        Job job = entitymanager.find(Job.class, jid);

        System.out.println("Job: " + job.toString());

        Employee emp = job.getEmployee();

        System.out.println("Employee: " + emp.toString());

        entitymanager.getTransaction().commit();

        entitymanager.close();
        emfactory.close();
    }

}
