/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package oodb.model;

/**
 *
 * @author Asus
 */
public class University {
    private String maTruong;
    private String diaChi;
    private String soDT;
    private Instructor instructor;
    private Department department;

    public University() {
    }
    
    
    

    public University(String maTruong, String diaChi, String soDT) {
        this.maTruong = maTruong;
        this.diaChi = diaChi;
        this.soDT = soDT;
    }

    public String getMaTruong() {
        return maTruong;
    }

    public void setMaTruong(String maTruong) {
        this.maTruong = maTruong;
    }

    public String getDiaChi() {
        return diaChi;
    }

    public void setDiaChi(String diaChi) {
        this.diaChi = diaChi;
    }

    public String getSoDT() {
        return soDT;
    }

    public void setSoDT(String soDT) {
        this.soDT = soDT;
    }

    public Instructor getInstructor() {
        return instructor;
    }

    public void setInstructor(Instructor instructor) {
        this.instructor = instructor;
    }

    public Department getDepartment() {
        return department;
    }

    public void setDepartment(Department department) {
        this.department = department;
    }

   @Override
public String toString() {
    return "University{" +
           "maTruong='" + maTruong + '\'' +
           ", diaChi='" + diaChi + '\'' +
           ", soDT='" + soDT + '\'' +
           ", instructor=" + (instructor != null ? instructor.getMaNV() : "null") +
           '}';
}

    
    

}
