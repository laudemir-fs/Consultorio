-- Tabela Exames
CREATE TABLE Exames (
    ExameID INT PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    Observacoes NVARCHAR(1000) NOT NULL,
    TipoExameID INT FOREIGN KEY REFERENCES TiposExame(TipoExameID) NOT NULL
);