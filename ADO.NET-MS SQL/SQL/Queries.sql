--A list of all Students
select * from Student

--A list of all Trainers
select * from Trainer


--A list of all Courses
select * from Course


--A list of all Projects

select * from Project


--Find students for each course
select S.FirstName, S.LastName, C.Title, C.CType, TuitionFees
from StudentPerCourse SPC
inner join Student S on S.Student_ID = SPC.Student_ID
inner join Course C on C.Course_ID = SPC.Course_ID
order by S.LastName asc;


--Find trainers for each course
select T.FirstName, T.LastName, T.TSubject, C.Title, C.CType 
from TrainerPerCourse TPC
inner join Trainer T on T.Trainer_ID = TPC.Trainer_ID 
inner join Course C on C.Course_ID = TPC.Course_ID
order by T.LastName asc


--Find projects for each course
select C.Title, C.CType, P.Title
from ProjectPerStudent PPS
inner join Project P on P.Project_ID = PPS.Project_ID
inner join Course C on C.Course_ID = PPS.Course_ID
order by P.Title asc


--Find students' projects for each course
select S.FirstName, S.LastName, C.Title, C.CType, P.Title, OralMark, TotalMark, P.SubmissionDate
from ProjectPerStudent PPS
inner join Project P on P.Project_ID = PPS.Project_ID
inner join Course C on C.Course_ID = PPS.Course_ID
inner join Student S on S.Student_ID = PPS.Student_ID
order by S.LastName;

--find all students who have more than one course
select Student.FirstName, Student.LastName, COUNT(Course.Course_ID) as Courses
from Student,StudentPerCourse,Course
where Student.Student_ID = StudentPerCourse.Student_ID and course.Course_ID = StudentPerCourse.Course_ID
group by Student.FirstName, Student.LastName
having COUNT(Course.Course_ID) > 1
order by Student.LastName asc

