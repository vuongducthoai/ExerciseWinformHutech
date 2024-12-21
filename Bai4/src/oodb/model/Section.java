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
public class Section {
      private String soHP;
      private int soTinChi;
      private String namHoc;
      private String phongHoc;
      private ArrayList<Course> listCourse = new ArrayList<>();
      private ArrayList<Student> listStudent = new ArrayList<>();
      private ArrayList<Instructor> listInstructor= new ArrayList<>();
    public Section() {
    }

    public String getSoHP() {
        return soHP;
    }

    public void setSoHP(String soHP) {
        this.soHP = soHP;
    }

    public int getSoTinChi() {
        return soTinChi;
    }

    public void setSoTinChi(int soTinChi) {
        this.soTinChi = soTinChi;
    }

    public String getNamHoc() {
        return namHoc;
    }

    public void setNamHoc(String namHoc) {
        this.namHoc = namHoc;
    }

    public String getPhongHoc() {
        return phongHoc;
    }

    public void setPhongHoc(String phongHoc) {
        this.phongHoc = phongHoc;
    }

    public ArrayList<Course> getListCourse() {
        return listCourse;
    }

    public void setListCourse(ArrayList<Course> listCourse) {
        this.listCourse = listCourse;
    }

    public ArrayList<Student> getListStudent() {
        return listStudent;
    }

    public void setListStudent(ArrayList<Student> listStudent) {
        this.listStudent = listStudent;
    }

    public ArrayList<Instructor> getListInstructor() {
        return listInstructor;
    }

    public void setListInstructor(ArrayList<Instructor> listInstructor) {
        this.listInstructor = listInstructor;
    }

    @Override
    public String toString() {
        return "Section{" + "soHP=" + soHP + ", soTinChi=" + soTinChi + ", namHoc=" + namHoc + ", phongHoc=" + phongHoc + ", listCourse=" + listCourse + ", listStudent=" + listStudent + ", listInstructor=" + listInstructor + '}';
    }
    
    
      
}
