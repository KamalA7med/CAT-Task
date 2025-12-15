CREATE TABLE StudentData(
student_id INT NOT NULL ,
name VARCHAR(50) ,
grade INT,
PRIMARY KEY (student_id)
);
INSERT INTO StudentData(student_id,name,grade)
VALUES(1,'Kamal ahmed',98),(2,'ALi Mohamed ',90),(3,'Osama Khalid',80),(4,'Ahmed  Mohamed ',93);
SELECT *FROM StudentData where grade between 90 and 100;