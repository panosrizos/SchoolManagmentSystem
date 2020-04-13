
USE RIZOS_DB_SCHOOL;

-- INSERT COURSES																				      
INSERT Course( Title,Stream,[Type],StartDate,EndDate ) VALUES ('CB8','Full Time', 'C#',              '2019-01-01','2019-03-31');
INSERT Course( Title,Stream,[Type],StartDate,EndDate ) VALUES ('CB8','Part Time', 'C#',              '2019-01-01','2019-06-29');
INSERT Course( Title,Stream,[Type],StartDate,EndDate ) VALUES ('CB8','Full Time', 'JAVA',            '2019-01-03','2019-04-03');
INSERT Course( Title,Stream,[Type],StartDate,EndDate ) VALUES ('CB9','Full Time', 'Python',          '2019-03-01','2019-06-30');
INSERT Course( Title,Stream,[Type],StartDate,EndDate ) VALUES ('CB9','Part Time', 'Machine Learning','2019-03-01','2019-09-28');

-- INSERT ASSIGNMENTS
INSERT INTO Assignment(Title,[Description],SubDateTime,OralMark,TotalMark) VALUES ('Individual', 'PartA','2019-1-21',50,50);
INSERT INTO Assignment(Title,[Description],SubDateTime,OralMark,TotalMark) VALUES ('Team',       'PartB','2019-2-25',60,40);
INSERT INTO Assignment(Title,[Description],SubDateTime,OralMark,TotalMark) VALUES ('Individual', 'PartA','2019-1-22',50,50);
INSERT INTO Assignment(Title,[Description],SubDateTime,OralMark,TotalMark) VALUES ('Team',       'PartB','2019-5-13',20,80);
INSERT INTO Assignment(Title,[Description],SubDateTime,OralMark,TotalMark) VALUES ('Individual', 'PartA','2019-2-11',50,50);
INSERT INTO Assignment(Title,[Description],SubDateTime,OralMark,TotalMark) VALUES ('Team',       'PartB','2019-3-16',50,50);
INSERT INTO Assignment(Title,[Description],SubDateTime) VALUES ('Individual', 'PartA','2019-4-11');
INSERT INTO Assignment(Title,[Description],SubDateTime) VALUES ('Semi_Final', 'PartB','2019-5-21');
INSERT INTO Assignment(Title,[Description],SubDateTime) VALUES ('Individual', 'PartA','2018-6-30');
INSERT INTO Assignment(Title,[Description],SubDateTime) VALUES ('Final',      'PartB','2018-8-30');

-- INSERT TRAINERS
INSERT INTO Trainer(FirstName,LastName,[Subject]) VALUES ('Ektoras',   'Gkatsos',            'OOP');
INSERT INTO Trainer(FirstName,LastName,[Subject]) VALUES ('Vurwnas',   'Vafiadis',           'OOP');
INSERT INTO Trainer(FirstName,LastName,[Subject]) VALUES ('Giorgos',   'Pavlou',             'OOP');
INSERT INTO Trainer(FirstName,LastName,[Subject]) VALUES ('Kwstas',    'Stroggulos',         'SQL');
INSERT INTO Trainer(FirstName,LastName,[Subject]) VALUES ('Panos',     'Ioannou',            'SQL');
INSERT INTO Trainer(FirstName,LastName,[Subject]) VALUES ('Ilias',     'Georgiou',           'SQL');
INSERT INTO Trainer(FirstName,LastName,[Subject]) VALUES ('Giorgos',   'Pasparakis',   'Front_End');
INSERT INTO Trainer(FirstName,LastName,[Subject]) VALUES ('Panos',     'Mpozas',       'Front_End');
INSERT INTO Trainer(FirstName,LastName,[Subject]) VALUES ('Maria',     'Nikou',        'Front_End');
INSERT INTO Trainer(FirstName,LastName,[Subject]) VALUES ('Kwstas',    'Zitis',   'Python_advance');
INSERT INTO Trainer(FirstName,LastName,[Subject]) VALUES ('Aliki',     'Tsirozidi',   'Consulting');
INSERT INTO Trainer(FirstName,LastName,[Subject]) VALUES ('Giannis',   'Nikou',       'Consulting');
INSERT INTO Trainer(FirstName,LastName,[Subject]) VALUES ('Despoina',  'Papadopoulou','Algorithms');



-- INSERT STUDENTS
INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees) VALUES ('Panos','Rizos',               '1993-3-19',1500);
INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees) VALUES ('Nikos','Ioannou',             '1992-5-13',1500);
INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees) VALUES ('Kostas','Dimitriou',          '1996-5-11',800);
INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees) VALUES ('Giorgos','Nikolaou',          '1994-2-3',1100);
INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees)	VALUES ('Panos','Kostantinou',         '1991-3-12',2000);
INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees)	VALUES ('Maria','Dimitriou',           '1995-3-11',800);
INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees)	VALUES ('Nikolas','Papadimitriou',     '1991-10-20',1900);
INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees)	VALUES ('Eleni','Parisi',              '1989-10-25',2200);
INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees)	VALUES ('Ksenofwntas','Vlachogiannis', '1989-6-05',1200);
INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees)	VALUES ('Karolos','Koniewitc',         '1994-7-12',155);
INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees) VALUES ('Giannis','Manthos',           '1980-6-11',1150);
INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees) VALUES ('Thanos','Katrakis',           '1993-10-21',2250);
INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees) VALUES ('Zaxarias','Drimiskianakis',   '1991-10-21',1115);
INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees) VALUES ('Alexandros','Perikleous',     '1995-10-4',2250);
INSERT INTO Student(FirstName,LastName,DateOfBirth,TuitionFees) VALUES ('Thanos','Christidis',         '1993-5-17',800);



--INSERT STUDENT_PER_COURSE

INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (1,1);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (1,2);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (1,3);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (1,4);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (1,5);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (2,6);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (2,7);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (2,8);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (2,9);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (2,10);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (3,11);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (3,12);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (3,13);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (3,14);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (3,1);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (4,15);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (4,2);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (5,5);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (5,1);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (5,11);
INSERT INTO StudentPerCourse(Course_ID,Student_ID) VALUES (5,12);


--INSERT ASSIGNMENT_PER_COURSE

INSERT INTO AssignmentPerCourse(Course_ID,Assignment_ID) VALUES (1,1);
INSERT INTO AssignmentPerCourse(Course_ID,Assignment_ID) VALUES (1,2);
INSERT INTO AssignmentPerCourse(Course_ID,Assignment_ID) VALUES (1,3);
INSERT INTO AssignmentPerCourse(Course_ID,Assignment_ID) VALUES (2,3);
INSERT INTO AssignmentPerCourse(Course_ID,Assignment_ID) VALUES (2,4);
INSERT INTO AssignmentPerCourse(Course_ID,Assignment_ID) VALUES (3,5);
INSERT INTO AssignmentPerCourse(Course_ID,Assignment_ID) VALUES (3,6);
INSERT INTO AssignmentPerCourse(Course_ID,Assignment_ID) VALUES (4,7);
INSERT INTO AssignmentPerCourse(Course_ID,Assignment_ID) VALUES (4,8);
INSERT INTO AssignmentPerCourse(Course_ID,Assignment_ID) VALUES (5,8);
INSERT INTO AssignmentPerCourse(Course_ID,Assignment_ID) VALUES (5,9);
INSERT INTO AssignmentPerCourse(Course_ID,Assignment_ID) VALUES (5,10);

--INSERT TRAINER_PER_COURSE

INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (1,1);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (1,2);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (1,4);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (1,7);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (1,11);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (2,2);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (2,5);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (2,8);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (2,12);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (3,3);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (3,6);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (3,9);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (3,11);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (4,10);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (4,4);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (4,12);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (5,13);
INSERT INTO TrainerPerCourse(Course_ID,Trainer_ID) VALUES (5,11);

