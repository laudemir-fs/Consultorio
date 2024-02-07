
-- Procedure para inserir um exame novo
CREATE PROCEDURE InserirExame
    @Nome NVARCHAR(100),
    @Observacoes NVARCHAR(1000),
    @TipoExameID INT
AS
BEGIN
    INSERT INTO Exames (Nome, Observacoes, TipoExameID)
    VALUES (@Nome, @Observacoes, @TipoExameID);
END;


-- Procedure para editar um exame existente
CREATE PROCEDURE EditarExame
    @ExameID INT,
    @Nome NVARCHAR(100),
    @Observacoes NVARCHAR(1000),
    @TipoExameID INT
AS
BEGIN
    UPDATE Exames
    SET Nome = @Nome,
        Observacoes = @Observacoes,
        TipoExameID = @TipoExameID
    WHERE ExameID = @ExameID;
END;


-- Procedure para excluir um exame
CREATE PROCEDURE ExcluirExame
    @ExameID INT
AS
BEGIN
    DELETE FROM Exames WHERE ExameID = @ExameID;
END;



-- Para inserir um exame
EXEC InserirExame @Nome = 'Exame 1', @Observacoes = 'Observações sobre o exame 1', @TipoExameID = 1;

-- Para editar um exame
EXEC EditarExame @ExameID = 1, @Nome = 'Exame 1 editado', @Observacoes = 'Observações editadas sobre o exame 1', @TipoExameID = 1;

-- Para excluir um exame
EXEC ExcluirExame @ExameID = 1;
