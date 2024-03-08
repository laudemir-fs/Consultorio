-- Tabela TiposExame
CREATE TABLE TiposExame (
    TipoExameID INT PRIMARY KEY,
    Nome NVARCHAR(100) NOT NULL,
    Descricao NVARCHAR(256) NOT NULL
);