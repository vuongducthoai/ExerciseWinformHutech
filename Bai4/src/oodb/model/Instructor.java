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
public class Instructor {
    private String maNV;
    private String hoTenNV;
    private double luong;
    private University university;
    private Department phuTrach; 
    private ArrayList<Department> departments = new ArrayList<>(); 
    private Section section;

    public Instructor() {
    }

    public Instructor(String maNV, String hoTenNV, double luong) {
        this.maNV = maNV;
        this.hoTenNV = hoTenNV;
        this.luong = luong;
    }
    
    
    
    public String getMaNV() {
        return maNV;
    }

    public void setMaNV(String maNV) {
        this.maNV = maNV;
    }

    public String getHoTenNV() {
        return hoTenNV;
    }

    public void setHoTenNV(String hoTenNV) {
        this.hoTenNV = hoTenNV;
    }

    public double getLuong() {
        return luong;
    }

    public void setLuong(double luong) {
        this.luong = luong;
    }

    public University getUniversity() {
        return university;
    }

    public void setUniversity(University university) {
        this.university = university;
    }

    public Department getPhuTrach() {
        return phuTrach;
    }

    public void setPhuTrach(Department phuTrach) {
        this.phuTrach = phuTrach;
    }

    public ArrayList<Department> getDepartments() {
        return departments;
    }

    public void setDepartments(ArrayList<Department> departments) {
        this.departments = departments;
    }


    public Section getSection() {
        return section;
    }

    public void setSection(Section section) {
        this.section = section;
    }

    @Override
    public String toString() {
        return "Instructor{" +
               "maNV='" + maNV + '\'' +
               ", hoTenNV='" + hoTenNV + '\'' +
               ", luong=" + luong +
               ", university=" + (university != null ? university.getMaTruong() : "null") +
               '}';
    }

}
