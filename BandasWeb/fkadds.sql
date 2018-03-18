use [C:\USERS\FEDE\DOCUMENTS\DESARROLLOWEB2018\COMIT\MUSICRSOLD\MUSICRS\BANDASWEB\BANDASWEB\APP_DATA\DATABASE1.MDF];
ALTER TABLE Usuarios
add FOREIGN KEY (Tipo_usuario) REFERENCES Rolex(Id);
ALTER TABLE Usuario_dueno
add FOREIGN KEY (Id_usuarios) REFERENCES Usuarios(Id);
ALTER TABLE Sala
add FOREIGN KEY (Id_dueno) REFERENCES Usuario_dueno(Id);
ALTER TABLE Detalle_sala
add FOREIGN KEY (Id_Sala) REFERENCES Sala(Id);
ALTER TABLE Carac_sala
add FOREIGN KEY (Id_Sala) REFERENCES Sala(Id);
ALTER TABLE Carac_sala
add FOREIGN KEY (Id_Caracteristicas) REFERENCES Caracteristicas(Id);
ALTER TABLE Horario_sala
add FOREIGN KEY (Id_horario) REFERENCES Horario(Id);
ALTER TABLE Horario_sala
add FOREIGN KEY (Id_sala) REFERENCES Sala(Id);
ALTER TABLE Reserva
add FOREIGN KEY (Id_horario_sala) REFERENCES Horario_sala(Id);
ALTER TABLE Reserva
add FOREIGN KEY (Id_usuario) REFERENCES Usuarios(Id);