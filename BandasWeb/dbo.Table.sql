CREATE TABLE [dbo].[Usuarios]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nombre] VARCHAR(50) NOT NULL, 
    [Apellido] VARCHAR(50) NOT NULL, 
    [Nombre_usuario] VARCHAR(50) NOT NULL, 
    [Contrasena] VARCHAR(12) NOT NULL, 
    [Telefono] VARCHAR(20) NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Tipo_usuario] INT NOT NULL
)
