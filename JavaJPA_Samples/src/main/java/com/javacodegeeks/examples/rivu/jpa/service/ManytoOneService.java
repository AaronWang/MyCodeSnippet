package com.javacodegeeks.examples.rivu.jpa.service;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

import com.javacodegeeks.examples.rivu.jpa.entity.Employee;
import com.javacodegeeks.examples.rivu.jpa.entity.Department;

public class ManytoOneService {

    public static void main(String[] args) {

        EntityManagerFactory emfactory = Persistence.createEntityManagerFactory("DerbyJPA");
        EntityManager entitymanager = emfactory.createEntityManager();
        entitymanager.getTransaction().begin();

        Department department = entitymanager.find(Department.class, 1);

        System.out.println("Department: " + department.getDname());

        entitymanager.getTransaction().commit();
        entitymanager.getTransaction().begin();

        entitymanager.persist(department);

        Employee employee = new Employee();
        employee.setEname("Rivu");
        employee.setSalary(25000);
//        employee.setJob_id(1);
        employee.setDepartment(department);

        entitymanager.persist(employee);

        int employeeId = employee.getEid();

        entitymanager.getTransaction().commit();

        entitymanager.getTransaction().begin();

        Employee dbEmployee = entitymanager.find(Employee.class, employeeId);
        System.out.println("Employee " + dbEmployee);

        entitymanager.getTransaction().commit();

        entitymanager.close();
        emfactory.close();

    }
}
