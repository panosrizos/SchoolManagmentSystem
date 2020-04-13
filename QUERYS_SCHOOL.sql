use RIZOS_DB_SCHOOL;


-- SELECT ALL STUDENTS
SELECT * FROM Student


-- SELECT ALL TRAINERS
SELECT * FROM Trainer



-- SELECT ALL ASSIGNMENTS
SELECT * FROM Assignment



-- SELECT ALL COURSES
SELECT * FROM Course


-- ALL THE ASSIGNMENTS PER COURSE

SELECT C.Title,C.[Type],C.Stream,A.Title as [Assignment Title],A.[Description]
from Assignment A  
INNER JOIN AssignmentPerCourse APC ON APC.Course_ID= A.Assignment_ID
INNER JOIN Course C ON APC.Course_ID = C.Course_ID




-- ALL THE TRAINERS PER COURSE

SELECT C.Title as [Course Title],C.[Type],C.Stream,T.FirstName as [Trainer FirstName],T.LastName FROM Trainer T
INNER JOIN TrainerPerCourse TPC ON TPC.Trainer_ID=T.Trainer_ID
INNER JOIN Course C ON TPC.Course_ID= C.Course_ID
ORDER BY C.Title,C.[Type], C.Stream




-- ALL THE STUDENTS PER COURSE

SELECT C.Title as [Course Title],C.[Type],C.Stream,S.FirstName as [Student FirstName],S.LastName  
FROM Student S
INNER JOIN StudentPerCourse SPC ON SPC.Student_ID= S.Student_ID
INNER JOIN Course C ON SPC.Course_ID = C.Course_ID



-- ALL THE ASSIGNMENTS PER COURSE PER STUDENTS

SELECT S.Student_ID, S.FirstName,S.LastName,C.Title AS [Course Title],A.Title AS [Assignment Title],A.[Description] 
FROM Student S
INNER JOIN StudentPerCourse SPC ON SPC.Student_ID = S.Student_ID
INNER JOIN Course C ON C.Course_ID = SPC.Course_ID
INNER JOIN AssignmentPerCourse APC ON C.Course_ID = APC.Course_ID
INNER JOIN Assignment A ON APC.Assignment_ID= A.Assignment_ID
ORDER BY S.Student_ID,C.Title


-- LIST OF STUDENTS WITH MORE THAN ONE COURSE 

SELECT S.FirstName,S.LastName, COUNT(C.Course_ID ) AS [Courses]
FROM STUDENT S,StudentPerCourse SPC, Course C
WHERE (S.Student_ID= SPC.Student_ID AND C.Course_ID= SPC.Course_ID)
GROUP BY S.FirstName,S.LastName
HAVING COUNT(C.Course_ID)>1
ORDER BY  COUNT(C.Course_ID ) DESC;