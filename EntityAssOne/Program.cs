
using EntityAssOne.Context;
using EntityAssOne.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace EntityAssOne
{
    internal class Program
    {
        static void Main(string[] args)
        {


      


            using ITiDBContext dbcontext = new ITiDBContext();
            dbcontext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;



            #region  Crud opertion Student Tbale
            //Student student = new Student()
            //{
            //    FName="Ahmed",
            //    LName="reda",
            //    Address="Cairo Giza",
            //    Age=27
            //};


            // dbcontext.Entry(student).State = EntityState.Added;

            //dbcontext.Add(student);



            //// update

            //var stud = dbcontext.students.SingleOrDefault(s => s.Id == 1);


            //if(stud!=null)
            //{

            //    stud.FName = "Dina";

            //}



            //// delete 

            //dbcontext?.Remove(stud);

            //dbcontext?.SaveChanges(); 
            #endregion



            #region Crud opertion Course Table


            //Course course = new Course()
            //{
            //    Duration = 5,
            //    Name = "C++",
            //    Description = "Intoduction to Programming",
            //    TopId = 1
            //};

            //// Add Course 
            //dbcontext.Add(course);


            ////update Course

            //var course01 = dbcontext.Set<Course>().SingleOrDefault(c => c.Id == 1);

            //if (course01 != null)
            //{
            //    course01.Name = "C#";
            //    course01.Description = "Introduction to oop";
            //}


            //// delete course

            //dbcontext.Courses.Remove(course01);

            //dbcontext.SaveChanges();

            #endregion



            #region Crud Opertion Department


            //Department department = new Department()
            //{

            //    Name = "AI",
            //    HireDate = DateTime.Now,
            //    Ins_ID = 5
            //};

            //// add Department

            //dbcontext.Set<Department>().Add(department);


            //// update 

            //var dept = dbcontext.Departments.SingleOrDefault(d => d.Id == 1);

            //if(dept!=null)
            //{
            //    dept.Name = "software Engineer";
            //}


            //// delete 

            //dbcontext.Departments.Remove(dept);


            //dbcontext.SaveChanges();

            #endregion


            #region Crud Course Instructor 

            //CourseInstructor courseInstructor = new CourseInstructor()
            //{
            //    CourseID = 10,
            //    Evalute = 8,
            //    InsID = 1
            //};


            //// Add

            //dbcontext.Add(courseInstructor);


            //// update 

            //var CInstructor = dbcontext.CourseInstructors.SingleOrDefault(c => c.Id == 1);

            //if(CInstructor!=null)
            //{
            //    CInstructor.Evalute = 10;
            //}


            //// deleted

            //dbcontext?.Remove(CInstructor);

            // dbcontext?.SaveChanges();




            #endregion


            #region Crud Operation StudentCourse

            //StudentCourse studentCourse = new StudentCourse()
            //{
            //    StusentId = 10,
            //    CourseId = 5,
            //    Grade = 8,
            //};

            //// add

            //dbcontext.Add(studentCourse);
            //dbcontext.SaveChanges();


            //// upadte 

            //var StudCourse = dbcontext.StudentCourse.SingleOrDefault(s=>s.Id==1);


            //if(StudCourse != null)
            //{
            //    StudCourse.CourseId = 11;
            //}



            //// deleted

            //dbcontext.Set<StudentCourse>().Remove(StudCourse);



            //dbcontext.SaveChanges();




            #endregion


            #region Crud opertion Topics

            // Topic topic = new Topic()
            // {

            //     Name =2,
            // };

            // // add

            //// dbcontext.Add(topic);



            // // update 


            // var t = dbcontext.Topics.SingleOrDefault(t=>t.Id==1);

            // if(t!=null)
            // {
            //     t.Name = 11;
            // }


            // // delete 

            // dbcontext.Remove(t);

            // dbcontext.SaveChanges();

            #endregion

        }
    }
}
