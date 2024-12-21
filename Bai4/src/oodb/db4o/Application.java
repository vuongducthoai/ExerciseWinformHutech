/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oodb.db4o;

/**
 *
 * @author turni
 */
import com.db4o.Db4oEmbedded;
import com.db4o.ObjectContainer;
import com.db4o.ObjectSet;
import com.db4o.query.Query;
import com.db4o.query.Predicate;

import java.util.List;
import java.util.Set;

import oodb.model.*;

public class Application {
    final static String DB_FILE = "basic_java.db4o";
    
    public static void main(final String[] args) {
        //Open database
        ObjectContainer db = Db4oEmbedded.openFile(Db4oEmbedded.
                newConfiguration(), DB_FILE);
        try {
//            clearDatabase(db);
//            storeObject(db);  //run one time    
//            queryDanhSachStudent(db);
            queryAllDepartments(db);
//            queryAllCourses(db);
//            queryInstructorsByDepartment(db,"Khoa CNTT");
//            queryStudentByName(db, "Nguyen Van D");
//            queryAllCourses(db);
//            nativeQueryStudentsByClass(db, "CNTT1");
//            nativeQueryInstructorsBySlary(db, 4000);
//            queryCoursesByInstructor(db, "Nguyen Van A");

//            System.out.println("Cập nhật thông tin lương giảng viên:");
//            updateInstructorSalary(db, "I005", 6000);
//            
//            System.out.println("Xóa một sinh viên:");
//            deleteStudent(db, "S002");
//            
//            System.out.println("Xóa toàn bộ danh sách khoa:");
//            deleteAllDepartments(db);

        } finally {
            db.close();
            //new File(Application.DB_FILE).delete();
        }
    }
    
    
    public static void clearDatabase(ObjectContainer db) {
        ObjectSet<Object> result = db.queryByExample(Object.class);
        for (Object obj : result) {
            db.delete(obj);
        }
        System.out.println("Đã xóa toàn bộ dữ liệu trong cơ sở dữ liệu.");
    }

    
    public static void storeObject(ObjectContainer db){
                     
        University university1 = new University("U001", "123 Main St", "0123456789");
        University university2 = new University("U002", "456 Elm St", "0987654321");
        University university3 = new University("U003", "789 Oak St", "0912345678");
        University university4 = new University("U004", "321 Pine St", "0934567890");
        University university5 = new University("U005", "654 Maple St", "0987654321");
                    
        Instructor instructor1 = new Instructor();
        instructor1.setMaNV("I001");
        instructor1.setHoTenNV("Nguyen Van A");
        instructor1.setLuong(3000);
        instructor1.setUniversity(university1);
        university1.setInstructor(instructor1);

        Instructor instructor2 = new Instructor();
        instructor2.setMaNV("I002");
        instructor2.setHoTenNV("Tran Thi B");
        instructor2.setLuong(3500);
        instructor2.setUniversity(university2);
        university2.setInstructor(instructor2);

        Instructor instructor3 = new Instructor();
        instructor3.setMaNV("I003");
        instructor3.setHoTenNV("Le Van C");
        instructor3.setLuong(4000);
        instructor3.setUniversity(university3);
        university3.setInstructor(instructor3);

        Instructor instructor4 = new Instructor();
        instructor4.setMaNV("I004");
        instructor4.setHoTenNV("Pham Thi D");
        instructor4.setLuong(4500);
        instructor4.setUniversity(university4);
        university4.setInstructor(instructor4);

        Instructor instructor5 = new Instructor();
        instructor5.setMaNV("I005");
        instructor5.setHoTenNV("Hoang Van E");
        instructor5.setLuong(5000);
        instructor5.setUniversity(university5);
        university5.setInstructor(instructor5);

        Department department1 = new Department();
        department1.setMaPB("D001");
        department1.setTenPB("Khoa CNTT");
        department1.setPhuTrach(instructor1);
        department1.getListInstructors().add(instructor1);
        department1.getListInstructors().add(instructor2);
        department1.getListInstructors().add(instructor3);
        department1.getListInstructors().add(instructor4);
        instructor1.getDepartments().add(department1);
        university1.setDepartment(department1);
        department1.getListUniversitys().add(university1);
        department1.getListUniversitys().add(university2);
        department1.getListUniversitys().add(university3);
        

        Department department2 = new Department();
        department2.setMaPB("D002");
        department2.setTenPB("Khoa Toan");
        department2.setPhuTrach(instructor2);
        department2.getListInstructors().add(instructor1);
        department2.getListInstructors().add(instructor2);
        instructor2.getDepartments().add(department2);
        university2.setDepartment(department2);
        department2.getListUniversitys().add(university2);
        department2.getListUniversitys().add(university3);

        Department department3 = new Department();
        department3.setMaPB("D003");
        department3.setTenPB("Khoa Ly");
        department3.setPhuTrach(instructor3);
        instructor3.getDepartments().add(department3);
        university3.setDepartment(department3);
        department3.getListUniversitys().add(university3);

        Department department4 = new Department();
        department4.setMaPB("D004");
        department4.setTenPB("Khoa Hoa");
        department4.setPhuTrach(instructor4);
        instructor4.getDepartments().add(department4);
        university4.setDepartment(department4);
        department4.getListUniversitys().add(university4);

        Department department5 = new Department();
        department5.setMaPB("D005");
        department5.setTenPB("Khoa Sinh");
        department5.setPhuTrach(instructor5);
        instructor5.getDepartments().add(department5);
        university5.setDepartment(department5);
        department5.getListUniversitys().add(university5);

        Course course1 = new Course();
        course1.setMaKhoaHoc("C001");
        course1.setTenKhoaHoc("Lap Trinh Java");
        course1.setKhoaGiangDay("Ky 1");

        Course course2 = new Course();
        course2.setMaKhoaHoc("C002");
        course2.setTenKhoaHoc("Lap Trinh Python");
        course2.setKhoaGiangDay("Ky 2");

        Course course3 = new Course();
        course3.setMaKhoaHoc("C003");
        course3.setTenKhoaHoc("Lap Trinh C++");
        course3.setKhoaGiangDay("Ky 1");

        Course course4 = new Course();
        course4.setMaKhoaHoc("C004");
        course4.setTenKhoaHoc("Khoa Hoc Du Lieu");
        course4.setKhoaGiangDay("Ky 2");

        Course course5 = new Course();
        course5.setMaKhoaHoc("C005");
        course5.setTenKhoaHoc("Tri Tue Nhan Tao");
        course5.setKhoaGiangDay("Ky 3");

        Student student1 = new Student();
        student1.setMaSV("S001");
        student1.setHoTenSV("Le Thi C");
        student1.setTenLop("CNTT1");
      

        Student student2 = new Student();
        student2.setMaSV("S002");
        student2.setHoTenSV("Nguyen Van D");
        student2.setTenLop("CNTT2");

        Student student3 = new Student();
        student3.setMaSV("S003");
        student3.setHoTenSV("Tran Van E");
        student3.setTenLop("CNTT3");

        Student student4 = new Student();
        student4.setMaSV("S004");
        student4.setHoTenSV("Pham Thi F");
        student4.setTenLop("CNTT4");

        Student student5 = new Student();
        student5.setMaSV("S005");
        student5.setHoTenSV("Hoang Van G");
        student5.setTenLop("CNTT5");

        Section section1 = new Section();
        section1.setSoHP("SEC001");
        section1.setSoTinChi(3);
        section1.setNamHoc("2024");
        section1.setPhongHoc("A101");
        instructor1.setSection(section1);
        student1.getSections().add(section1);
        student2.getSections().add(section1);
        section1.getListCourse().add(course1);
        section1.getListCourse().add(course2);
        course1.setSection(section1);
        
          
        Section section2 = new Section();
        section2.setSoHP("SEC002");
        section2.setSoTinChi(4);
        section2.setNamHoc("2025");
        section2.setPhongHoc("B202");
        student1.getSections().add(section2);
        student2.getSections().add(section2);
        instructor2.setSection(section2);
        section2.getListCourse().add(course3);
        course2.setSection(section2);

        Section section3 = new Section();
        section3.setSoHP("SEC003");
        section3.setSoTinChi(5);
        section3.setNamHoc("2024");
        section3.setPhongHoc("C303");
        student3.getSections().add(section3);
        instructor3.setSection(section3);
        section3.getListCourse().add(course4);
        course3.setSection(section3);

        Section section4 = new Section();
        section4.setSoHP("SEC004");
        section4.setSoTinChi(2);
        section4.setNamHoc("2025");
        section4.setPhongHoc("D404");
        student4.getSections().add(section4);
        instructor4.setSection(section4);
        section4.getListCourse().add(course5);
        course4.setSection(section4);

        Section section5 = new Section();
        section5.setSoHP("SEC005");
        section5.setSoTinChi(3);
        section5.setNamHoc("2024");
        section5.setPhongHoc("E505");
        student5.getSections().add(section5);
        instructor4.setSection(section5);
        section5.getListCourse().add(course1);
        course4.setSection(section5);
        
        
        BangDiem bangDiem1 = new BangDiem();
        bangDiem1.setDiem(10);
        bangDiem1.setStudent(student1);
        bangDiem1.setSection(section1);
        
        BangDiem bangDiem2 = new BangDiem();
        bangDiem2.setDiem(10);
        bangDiem2.setStudent(student1);
        bangDiem2.setSection(section1);
        
         BangDiem bangDiem3 = new BangDiem();
        bangDiem3.setDiem(10);
        bangDiem3.setStudent(student1);
        bangDiem3.setSection(section1);
        
         BangDiem bangDiem4 = new BangDiem();
        bangDiem4.setDiem(10);
        bangDiem4.setStudent(student1);
        bangDiem4.setSection(section1);
        
        
        BangDiem bangDiem5 = new BangDiem();
        bangDiem5.setDiem(10);
        bangDiem5.setStudent(student1);
        bangDiem5.setSection(section1);
        
        // Lưu các đối tượng vào DB4O
        db.store(university1);
        db.store(university2);
        db.store(university3);
        db.store(university4);
        db.store(university5);

        db.store(instructor1);
        db.store(instructor2);
        db.store(instructor3);
        db.store(instructor4);
        db.store(instructor5);

        db.store(department1);
        db.store(department2);
        db.store(department3);
        db.store(department4);
        db.store(department5);

        db.store(course1);
        db.store(course2);
        db.store(course3);
        db.store(course4);
        db.store(course5);

        db.store(student1);
        db.store(student2);
        db.store(student3);
        db.store(student4);
        db.store(student5);

        db.store(section1);
        db.store(section2);
        db.store(section3);
        db.store(section4);
        db.store(section5);
        
        db.store(bangDiem1);
        db.store(bangDiem2);
        db.store(bangDiem3);
        db.store(bangDiem4);
        db.store(bangDiem5);
    }
    
    public static void listResult(List<?> result){
        System.out.println(result.size());
        for(Object o : result){
            System.out.println(o);
        }
    }
    
    //QBE
    //Truy vấn danh sách student
    public static void queryDanhSachStudent(ObjectContainer db){
        ObjectSet result = db.queryByExample(Student.class);
        listResult(result);
    }
    
    // Truy vấn tất cả các khóa học
    public static void queryAllCourses(ObjectContainer db){
        Course example = new Course();
        ObjectSet<Course> result = db.queryByExample(example);
        System.out.println("Danh sách tất cả các khóa học:");
        listResult(result);
    }
    
    //Truy vấn tất cả các phòng ban
    public static void queryAllDepartments(ObjectContainer db) {
        ObjectSet<Department> result = db.queryByExample(Department.class);
        if (result.isEmpty()) {
            System.out.println("Cơ sở dữ liệu không có bất kỳ khoa nào.");
            return;
        }
        System.out.println("Danh sách tất cả các khoa:");
        listResult(result);
    }

    
    //Truy vấn danh sách sinh viên có tên cụ thể
    public static void queryStudentByName(ObjectContainer db, String name) {
        Student example = new Student();
        example.setHoTenSV(name);
        ObjectSet<Student> result = db.queryByExample(example);
        System.out.println("Danh sách sinh viên tên " + name + ":");
        listResult(result);
    }
    
    //Truy vấn các khóa học được giảng dạy bởi một giảng viên cụ thể
    public static void queryCoursesByInstructor(ObjectContainer db, String instructorName) {
        Query query = db.query();
        query.constrain(Course.class);
        query.descend("listDepartment").descend("phuTrach").descend("hoTenNV").constrain(instructorName);
        ObjectSet<Course> result = query.execute();
        System.out.println("Danh sách các khóa học của giảng viên " + instructorName + ":");
        listResult(result);
    }
    
    
    //Truy vấn giảng viên thuộc 1 khoa cụ thể
    public static void queryInstructorsByDepartment(ObjectContainer db, String departmentName){
        Query query = db.query();
        query.constrain(Department.class);
        query.descend("tenPB").constrain(departmentName);
        ObjectSet<Department> result = query.execute();
        if(result.isEmpty()){
            System.out.println("Không tìm thấy khoa nào có tên: " + departmentName);
            return;
        }
        System.out.println("Danh sách giảng viên thuộc khoa " + departmentName);
        for(Department department : result){
        listResult(department.getListInstructors());    
        }
    }
    
    //Native Query 
    //Tìm tất cả sinh viên trong một lớp cụ thể
    public static void nativeQueryStudentsByClass(ObjectContainer db, String className){
        List<Student> result = db.query(new Predicate<Student>(){
            @Override
            public boolean match(Student student) {
                return student.getTenLop().equals(className);
            }
        });
        System.out.println("Danh sách sinh viên trong lớp " + className + ":");
        listResult(result);
    }
    
    
    //Tim các giang vien co luong tren mot nguong cu the
    public static void nativeQueryInstructorsBySlary(ObjectContainer db, double minSlary){
        List<Instructor> result = db.query(new Predicate<Instructor>(){
              @Override
            public boolean match(Instructor instructor) {
                return instructor.getLuong() > minSlary;
            }
        });
        System.out.println("Danh sách giảng viên có lương trên " + minSlary + ":");
        listResult(result);
    }
    
    //Truy vấn giảng viên giảng dạy nhiều hơn một khóa học (QBE với điều kiện số lượng)
    public static void queryInstructorsWithMultipleCourses(ObjectContainer db) {
       Query query = db.query();
       query.constrain(Instructor.class);
       query.descend("section").descend("listCourse").constrain(1).greater();
       ObjectSet<Instructor> result = query.execute();

       System.out.println("Danh sách giảng viên giảng dạy nhiều hơn một khóa học:");
       listResult(result);
   }
    
    public static void updateInstructorSalary(ObjectContainer db, String instructorId, double newSalary) {
        // Truy vấn đối tượng Giảng viên dựa vào mã ID
        ObjectSet<Instructor> result = db.queryByExample(new Instructor(instructorId, null, 0));
        if (result.hasNext()) {
            Instructor instructor = result.next();
            System.out.println("Giảng viên trước khi cập nhật: " + instructor);
            // Cập nhật thông tin
            instructor.setLuong(newSalary);
            db.store(instructor);
            System.out.println("Giảng viên sau khi cập nhật: " + instructor);
        } else {
            System.out.println("Không tìm thấy giảng viên với ID: " + instructorId);
        }
    }
    
    public static void deleteStudent(ObjectContainer db, String studentId) {
        // Truy vấn đối tượng Sinh viên dựa vào mã ID
        ObjectSet<Student> result = db.queryByExample(new Student(studentId, null, null));
        if (result.hasNext()) {
            Student student = result.next();
            System.out.println("Xóa sinh viên: " + student);
            // Xóa đối tượng
            db.delete(student);
        } else {
            System.out.println("Không tìm thấy sinh viên với ID: " + studentId);
        }
    }
    
    
    public static void deleteAllDepartments(ObjectContainer db) {
        ObjectSet<Department> result = db.queryByExample(Department.class);
        for (Department department : result) {
            System.out.println("Xóa khoa: " + department);
            db.delete(department);
        }
        System.out.println("Đã xóa toàn bộ danh sách các khoa.");
    }
    
}



