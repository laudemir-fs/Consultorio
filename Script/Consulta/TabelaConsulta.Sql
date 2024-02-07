-- Tabela Consultas
CREATE TABLE Consultas (
    ConsultaID INT PRIMARY KEY,
    PacienteID INT FOREIGN KEY REFERENCES Pacientes(PacienteID) NOT NULL,
    ExameID INT FOREIGN KEY REFERENCES Exames(ExameID) NOT NULL,
    DataHora DATETIME NOT NULL,
    Protocolo NVARCHAR(100) UNIQUE NOT NULL
);