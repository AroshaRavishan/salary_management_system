create database Employee_Management_System 

create table Employee_Details
(
   Emp_ID varchar(100) not null primary key,
   Emp_Name varchar(100) not null,
   Emp_Address varchar(100) not null,
   Emp_Position varchar(100) not null,
   Emp_Education varchar(100) not null,
   Emp_Gender varchar(100) not null,
   Emp_Tel decimal not null,
   Emp_DOB date not null
);
ALTER TABLE Employee_Details
ADD Attendance_Details varchar(255);

create table paysheet
(
paysheet_id varchar(100) not null  ,
Emp_ID varchar(100) not null  FOREIGN KEY REFERENCES Employee_Details(Emp_ID),
Emp_Month varchar(100) not null,
Emp_work_days varchar(100) not null ,
Emp_salary varchar(100)
);

create table mark_Attendance
(
Emp_ID varchar(100) not null ,
Emp_Date date not null,
Emp_attendane varchar(1000) not null,
);

create table Message_box
(
message_show varchar(500) not null
);