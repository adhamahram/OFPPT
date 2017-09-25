create database GESTION_ABSENCE
go
use GESTION_ABSENCE
go
create table Stagiaires (
	Id_Cin			varchar(255) primary key ,
	Nom				varchar(255),
	Prenom			varchar(255),
	Groupe			int foreign key references Groupes(Id_groupe),
	Promotion		varchar(255),
	proposition		varchar (50) constraint CK_Stagiaires_Proposition check(proposition in ( 'admis', 'redoublent', 'Elimine')   
)
alter table Stagiaires
		drop constraint CK_Stagiaires_Proposition
go
create table Modules (
	 Id_module  int primary key,
	 nom_module varchar(255),
)
go
create table Groupes(
	Id_groupe	int primary key,  
	nom_groupe	varchar(255),
	Filiere		int foreign key references Filieres(id_filiere),
) 
--create table Affectations (
--	Module		int foreign key references Modules(Id_module),
--	Groupe		int foreign key references Groupes(Id_groupe),
--	primary key  (Module, Groupe),
--)

go
create table Filieres(
	Id_filiere  int primary key ,
	nom_filiere varchar(255),
)
go
create table Absences(
	Id_abs			int primary key ,
	Justification	bit,
	descriptions	varchar(255),
	Date_abs		date,
	Duree_abs		int,
	modules			int foreign key references Modules(Id_module),
	Stagiaire		varchar(255) foreign key references Stagiaires(Id_Cin),
)
go
create table    Archive_Stg(
	Id_Cin			varchar(255) primary key ,
	Nom_stagi		varchar(255),
	Prenom_stagi	varchar(255),
	Groupe			int foreign key references Groupes(Id_groupe),
	Filiere			int foreign key references Filieres(id_filiere),
	Promotion		varchar(255),
	Status			varchar(255), 
)
go
create table Archive_abs (
	Id_arch_abs		int,
	Justification	bit,
	descriptions	varchar(255),
	Date_abs		date,
	Duree_abs		int,
	modules			int foreign key references Modules(Id_module),
	Stagiaire		varchar(255) foreign key references Archive_Stg(Id_Cin),
)
go 
