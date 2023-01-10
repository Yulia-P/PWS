create database Services_Lab6

drop table Student

create table Student
(
	Id int Identity (1,1) primary key,
	Name  nvarchar(100) not null
);

drop table Note

create table Note
(
	Id int Identity (1,1) primary key,
	Id_student int not null foreign key (id_student) references Student(id),
	Subj  nvarchar(20) not null,
	Note  INT not null
);

select * from Student
select * from Note

insert into Student(Name) values ('Yulia');
insert into Student(Name) values ('Lera');
insert into Student(Name) values ('Kara');

insert into Note(Id_student, Subj, Note) values (1, 'PI', 7);
insert into Note(Id_student, Subj, Note) values (1, 'CMS', 6);
insert into Note(Id_student, Subj, Note) values (1, 'Math', 8);
insert into Note(Id_student, Subj, Note) values (2, 'PI', 7);
insert into Note(Id_student, Subj, Note) values (2, 'CMS', 8);
insert into Note(Id_student, Subj, Note) values (2, 'Math', 9);
insert into Note(Id_student, Subj, Note) values (3, 'PI', 8);
insert into Note(Id_student, Subj, Note) values (3, 'CMS', 7);
insert into Note(Id_student, Subj, Note) values (3, 'Math', 9);