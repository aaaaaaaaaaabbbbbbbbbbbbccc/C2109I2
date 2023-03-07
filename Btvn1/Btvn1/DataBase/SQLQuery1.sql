use master 
go

Drop database  if exists BTVNCSharp
create database BTVNCSharp
go

use BTVNCSharp
go


create table Course(
couId int primary key identity,
couName nvarchar(200) not null,
couSemester int not null
)
go

create table Exam(
examId int primary key identity,
examName nvarchar(200) not null,
examMark float not null,
examDate Date not null,
stuId int not null,
couId int not null
)
go

create table Student(
stuId int primary key identity,
stuPass nvarchar(100) not null,
stuName nvarchar(200) not null,
stuAddress nvarchar(300) not null,
stuPhone int not null,
stuEmail varchar(200) not null,
deptId int not null
)
go
