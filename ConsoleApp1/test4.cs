using System;
using System.Collections;

namespace test4
{
    class Announcement
    {
        private Student student;
        private Teacher teacher;
        private string noticeMsg_student;
        private string noticeMsg_teacher;

        //학생
        public Announcement(Student student)
        {
            this.student = student;
        }

        public void norifyStudents()
        {
            student.update(this.noticeMsg_student);
        }

        public void setNoticeMsg_student(string newNoticeMsg)
        {
            this.noticeMsg_student = newNoticeMsg;
            this.norifyStudents();
        }

        //선생
        public Announcement(Teacher teacher)
        {
            this.teacher = teacher;
        }

        public void norifyTeachers()
        {
            teacher.update(this.noticeMsg_teacher);
        }

        public void setNoticeMsg_teacher(string newNoticeMsg)
        {
            this.noticeMsg_teacher = newNoticeMsg;
            this.norifyTeachers();
        }

    }

    class Student
    {
        private string noticeMsg_student;
        private Announcement announce;
        private string stuName;

        public Student(string stuName)
        {
            this.stuName = stuName;
        }

        public void update(string newNoticeMsg)
        {
            this.noticeMsg_student = newNoticeMsg;
            display();
        }

        public void registerAnnouncement(Announcement announce)
        {
            this.announce = announce;
        }

        public void display()
        {
            Console.WriteLine($"{this.stuName} 학생을 위한 새로운 공지 : {this.noticeMsg_student}");
        }
    }



    class Teacher
    {
        private string noticeMsg_teacher;
        private Announcement announce;
        private string teaName;

        public Teacher(string teaName)
        {
            this.teaName = teaName;
        }

        public void update(string newNoticeMsg)
        {
            this.noticeMsg_teacher = newNoticeMsg;
            display();
        }

        public void registerAnnouncement(Announcement announce)
        {
            this.announce = announce;
        }

        public void display()
        {
            Console.WriteLine($"{this.teaName} 교직원을 위한 새로운 공지 : {this.noticeMsg_teacher}");
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
            Student a = new Student("a");
            Announcement anounce = new Announcement(a);
            a.registerAnnouncement(anounce);

            Student b = new Student("b");
            Announcement banounce = new Announcement(b);
            b.registerAnnouncement(banounce);

            Student c = new Student("c");
            Announcement canounce = new Announcement(c);
            c.registerAnnouncement(canounce);

            Student d = new Student("d");
            Announcement danounce = new Announcement(d);
            d.registerAnnouncement(danounce);

            Teacher t = new Teacher("t");
            Announcement tanounce = new Announcement(t);
            t.registerAnnouncement(tanounce);


            anounce.setNoticeMsg_student("첫 번째 공지 입니다.");

            banounce.setNoticeMsg_student("두 번째 공지 입니다.");

            canounce.setNoticeMsg_student("셋 번째 공지 입니다.");

            danounce.setNoticeMsg_student("네 번째 공지 입니다.");



            tanounce.setNoticeMsg_teacher("첫 번째 공지 입니다.");

        }
    }
}
