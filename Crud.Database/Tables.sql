--DATABASE NAME: escuela
--


CREATE TABLE Estudiante (
    EstudianteId INT IDENTITY(1,1),
    Apellidos varchar(255),
    Nombre varchar(255),
    Direccion varchar(255),
    Observaciones varchar(255),
    PRIMARY KEY (EstudianteId)
);


CREATE TABLE Materia (
    MateriaId INT IDENTITY(1,1),
    Nombre varchar(255),
    Observaciones varchar(255),
    PRIMARY KEY (MateriaId)
);