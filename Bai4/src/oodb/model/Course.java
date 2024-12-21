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
public class Course {
    private String maKhoaHoc;
    private String tenKhoaHoc;
    private String khoaGiangDay;
    private ArrayList<Department> listDepartment = new ArrayList<>();
    private Section section;

    public Course() {
    }

    public String getMaKhoaHoc() {
        return maKhoaHoc;
    }

    public void setMaKhoaHoc(String maKhoaHoc) {
        this.maKhoaHoc = maKhoaHoc;
    }

    public String getTenKhoaHoc() {
        return tenKhoaHoc;
    }

    public void setTenKhoaHoc(String tenKhoaHoc) {
        this.tenKhoaHoc = tenKhoaHoc;
    }

    public String getKhoaGiangDay() {
        return khoaGiangDay;
    }

    public void setKhoaGiangDay(String khoaGiangDay) {
        this.khoaGiangDay = khoaGiangDay;
    }

    public ArrayList<Department> getListDepartment() {
        return listDepartment;
    }

    public void setListDepartment(ArrayList<Department> listDepartment) {
        this.listDepartment = listDepartment;
    }

    public Section getSection() {
        return section;
    }

    public void setSection(Section section) {
        this.section = section;
    }

  @Override
public String toString() {
    return "Course{" +
           "maKhoaHoc='" + maKhoaHoc + '\'' +
           ", tenKhoaHoc='" + tenKhoaHoc + '\'' +
           ", khoaGiangDay='" + khoaGiangDay + '\'' +
           ", listDepartmentSize=" + (listDepartment != null ? listDepartment.size() : 0) +
           ", section=" + (section != null ? section.getSoHP() : "null") +
           '}';
}

    
    
}
