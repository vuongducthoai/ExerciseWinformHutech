/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package oodb.model;
import java.util.*;

/**
 *
 * @author Asus
 */
public class Department {
    private String maPB;
    private String tenPB;
    private ArrayList<University> listUniversitys = new ArrayList<>();
     private Instructor phuTrach;
     private ArrayList<Instructor> listInstructors = new ArrayList<>();
    public Department() {
    }

    
    public String getMaPB() {
        return maPB;
    }

    public void setMaPB(String maPB) {
        this.maPB = maPB;
    }

    public String getTenPB() {
        return tenPB;
    }

    public void setTenPB(String tenPB) {
        this.tenPB = tenPB;
    }

    public ArrayList<University> getListUniversitys() {
        return listUniversitys;
    }

    public void setListUniversitys(ArrayList<University> listUniversitys) {
        this.listUniversitys = listUniversitys;
    }

    public Instructor getPhuTrach() {
        return phuTrach;
    }

    public void setPhuTrach(Instructor phuTrach) {
        this.phuTrach = phuTrach;
    }

    public ArrayList<Instructor> getListInstructors() {
        return listInstructors;
    }

    public void setListInstructors(ArrayList<Instructor> listInstructors) {
        this.listInstructors = listInstructors;
    }

    @Override
    public String toString() {
        return "Department{" + "maPB=" + maPB + ", tenPB=" + tenPB + ", listUniversitys=" + listUniversitys + ", phuTrach=" + phuTrach + ", listInstructors=" + listInstructors + '}';
    }
    
    
}
