-- Procedure para inserir um novo TipoExame
CREATE PROCEDURE InserirTipoExame
    @Nome NVARCHAR(100),
    @Descricao NVARCHAR(256)
AS
BEGIN
    INSERT INTO TiposExame (Nome, Descricao)
    VALUES (@Nome, @Descricao);
END;

-- Procedure para editar um TipoExame existente
CREATE PROCEDURE EditarTipoExame
    @TipoExameID INT,
    @Nome NVARCHAR(100),
    @Descricao NVARCHAR(256)
AS
BEGIN
    UPDATE TiposExame
    SET Nome = @Nome,
        Descricao = @Descricao
    WHERE TipoExameID = @TipoExameID;
END;

-- Procedure para excluir um TipoExame
CREATE PROCEDURE ExcluirTipoExame
    @TipoExameID INT
AS
BEGIN
    DELETE FROM TiposExame WHERE TipoExameID = @TipoExameID;
END;


-- Para inserir um TipoExame
EXEC InserirTipoExame @Nome = 'Hemograma', @Descricao = 'Exame de sangue completo';

-- Para editar um TipoExame
EXEC EditarTipoExame @TipoExameID = 1, @Nome = 'Hemograma editado', @Descricao = 'Exame de sangue completo editado';

-- Para excluir um TipoExame
EXEC ExcluirTipoExame @TipoExameID = 1;
