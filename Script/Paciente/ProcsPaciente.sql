-- Procedure para inserir um novo paciente
CREATE PROCEDURE InserirPaciente
    @Nome NVARCHAR(100),
    @CPF NVARCHAR(11),
    @DataNascimento DATE,
    @Sexo NVARCHAR(10),
    @Telefone NVARCHAR(15),
    @Email NVARCHAR(100)
AS
BEGIN
    INSERT INTO Pacientes (Nome, CPF, DataNascimento, Sexo, Telefone, Email)
    VALUES (@Nome, @CPF, @DataNascimento, @Sexo, @Telefone, @Email);
END;

-- Procedure para listar todos os pacientes
CREATE PROCEDURE ListarPacientes
AS
BEGIN
    SELECT * FROM Pacientes;
END;

-- Procedure para editar um paciente existente
CREATE PROCEDURE EditarPaciente
    @PacienteID INT,
    @Nome NVARCHAR(100),
    @CPF NVARCHAR(11),
    @DataNascimento DATE,
    @Sexo NVARCHAR(10),
    @Telefone NVARCHAR(15),
    @Email NVARCHAR(100)
AS
BEGIN
    UPDATE Pacientes
    SET Nome = @Nome,
        CPF = @CPF,
        DataNascimento = @DataNascimento,
        Sexo = @Sexo,
        Telefone = @Telefone,
        Email = @Email
    WHERE PacienteID = @PacienteID;
END;

-- Procedure para excluir um paciente
CREATE PROCEDURE ExcluirPaciente
    @PacienteID INT
AS
BEGIN
    DELETE FROM Pacientes WHERE PacienteID = @PacienteID;
END;