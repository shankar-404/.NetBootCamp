create database assignment3;
use assignment3;

--Creating table Department
create table Department(dept_no INT NOT NULL, dept_name varchar(20) NOT NULL, location varchar(20) NOT NULL, primary key(dept_no));
select* from Department;

insert into Department values(1, 'Research', 'Dallas');
insert into Department values(2, 'Accounting', 'Seattle');
insert into Department values(3, 'Marketing', 'Dallas');


--Creating Table Employee
create table Employee(emp_no INT NOT NULL, emp_fname varchar(20) NOT NULL, emp_lname varchar(20) NOT NULL, dept_no int not null, primary key(emp_no), foreign key (dept_no) references Department(dept_no));

insert into Employee values(25348, 'Matthew', 'Smith', 3);
insert into Employee values(10102, 'Ann', 'Jones', 3);
select * from Employee

--Creating Table Project
create table Project(proj_no INT NOT NULL, proj_name varchar(20) NOT NULL, budget int not null, primary key(proj_no));

insert into Project values(1, 'Apollo', 120000);
insert into Project values(2, 'Gemini', 95000);
insert into Project values(3, 'Mercury', 185600);
select * from Project

--Creating Table Works_On
create table works_on(emp_no int not null, proj_no INT NOT NULL, job varchar(20), enter_date date not null, foreign key(emp_no) references employee(emp_no), foreign key(proj_no) references project(proj_no));
insert into works_on values(10102, 1, 'Analyst', '1997.10.1');
insert into works_on values(10102, 3, 'Manager', '1999.1.1');
insert into works_on values(25348, 2, 'Clerk', '1998.2.15');


--Q1
select * from works_on;

--Q2
select emp_no from works_on where job='Clerk';

--Q3
select emp_no from works_on where proj_no=2 and emp_no<10000;

--Q4
select emp_no from works_on where year(enter_date)!=1998;

--Q5
select emp_no from works_on where job in ('Analyst','Manager') and proj_no=1;

--Q6
select enter_date from works_on where (job is null and proj_no='p2');

--Q7
select emp_no,emp_lname from Employee where emp_fname like '%tt%';
