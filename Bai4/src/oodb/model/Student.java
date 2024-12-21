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
public class Student {
    private String maSV;
    private String hoTenSV;
    private String tenLop;
   private ArrayList<Department> departments = new ArrayList<>();
   private ArrayList<Section> sections = new ArrayList<>();

    public Student() {
    }

    
   
    public Student(String maSV, String hoTenSV, String tenLop) {
        this.maSV = maSV;
        this.hoTenSV = hoTenSV;
        this.tenLop = tenLop;
    }

   
   
    public String getMaSV() {
        return maSV;
    }

    public void setMaSV(String maSV) {
        this.maSV = maSV;
    }

    public String getHoTenSV() {
        return hoTenSV;
    }

    public void setHoTenSV(String hoTenSV) {
        this.hoTenSV = hoTenSV;
    }

    public String getTenLop() {
        return tenLop;
    }

    public void setTenLop(String tenLop) {
        this.tenLop = tenLop;
    }

    public ArrayList<Department> getDepartments() {
        return departments;
    }

    public void setDepartments(ArrayList<Department> departments) {
        this.departments = departments;
    }

    public ArrayList<Section> getSections() {
        return sections;
    }

    public void setSections(ArrayList<Section> sections) {
        this.sections = sections;
    }

    @Override
    public String toString() {
        return "Student{" + "maSV=" + maSV + ", hoTenSV=" + hoTenSV + ", tenLop=" + tenLop + ", departments=" + departments + ", sections=" + sections + '}';
    }
   
   
   
}
