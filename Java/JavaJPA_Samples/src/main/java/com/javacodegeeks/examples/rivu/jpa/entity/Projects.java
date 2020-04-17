package com.javacodegeeks.examples.rivu.jpa.entity;

import java.io.Serializable;

import javax.persistence.*;

/**
 * Entity implementation class for Entity: Department
 *
 */
@Entity

public class Projects implements Serializable {

    private static final long serialVersionUID = 1L;

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private int p_id;
    private String title;

    @ManyToOne
    @JoinColumn(name = "eid")
    private Employee employee;

    public Projects() {
        super();
    }

    public Projects(int p_id, String title, Employee employee) {
        super();
        this.p_id = p_id;
        this.title = title;
        this.employee = employee;
    }

    public int getP_id() {
        return p_id;
    }

    public void setP_id(int p_id) {
        this.p_id = p_id;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public Employee getEmployee() {
        return employee;
    }

    public void setEmployee(Employee employee) {
        this.employee = employee;
    }

    @Override
    public String toString() {
        return "[Project ID=" + p_id + " Title=" + title + " ]";
    }
}
