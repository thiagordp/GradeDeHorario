USE [GradeHorario]

CREATE TABLE PRE_REQUISITO (
CODIGO_DISCIPLINA VARCHAR(10),
CODIGO_DISCIPLINA_REQUISITO VARCHAR(10),
PRIMARY KEY(CODIGO_DISCIPLINA,CODIGO_DISCIPLINA_REQUISITO)
)

CREATE TABLE DISCIPLINA (
CODIGO_DISCIPLINA VARCHAR(10) PRIMARY KEY,
CREDITO_DISCIPLINA INT,
NOME_DISCIPLINA VARCHAR(150),
CODIGO_DEPARTAMENTO INT
)

CREATE TABLE DEPARTAMENTO (
CODIGO_DEPARTAMENTO INT PRIMARY KEY,
NOME_DEPARTAMENTO VARCHAR(100)
)

CREATE TABLE DISCIPLINA_TURMA (
SEQ_TURMA INT,
SEQ_DISCIPLINA_CURSO INT,
PRIMARY KEY(SEQ_TURMA,SEQ_DISCIPLINA_CURSO)
)

CREATE TABLE TURMA (
SEQ_TURMA INT PRIMARY KEY IDENTITY(1,1),
NOME_TURMA VARCHAR(10),
SEQ_SEMESTRE INT
)

CREATE TABLE ESPACO (
CODIGO_ESPACO VARCHAR(15) PRIMARY KEY,
QUADRO_VIDRO_ESPACO BIT,
PROJETOR_ESPACO BIT,
INTERNET_ESPACO BIT,
CAPACIDADE_ESPACO INT,
QUADRO_BRANCO_ESPACO BIT,
TIPO_ESPACO VARCHAR(20),
NUMERO_PC_ESPACO INT
)

CREATE TABLE ESPACO_TURMA (
CODIGO_ESPACO VARCHAR(15),
SEQ_TURMA INT,
SEQ_DISCIPLINA_CURSO INT,
PRIMARY KEY(CODIGO_ESPACO,SEQ_TURMA,SEQ_DISCIPLINA_CURSO),
FOREIGN KEY(SEQ_TURMA, SEQ_DISCIPLINA_CURSO) REFERENCES DISCIPLINA_TURMA (SEQ_TURMA, SEQ_DISCIPLINA_CURSO)
)

CREATE TABLE CURSO (
CODIGO_CURSO INT PRIMARY KEY,
NOME_CURSO VARCHAR(100)
)

CREATE TABLE PROFESSOR (
NOME_PROFESSOR VARCHAR(200),
CODIGO_PROFESSOR INT PRIMARY KEY,
CODIGO_DEPARTAMENTO INT,
FOREIGN KEY(CODIGO_DEPARTAMENTO) REFERENCES DEPARTAMENTO (CODIGO_DEPARTAMENTO)
)

CREATE TABLE PROFESSOR_TURMA (
CODIGO_PROFESSOR INT,
SEQ_TURMA INT,
SEQ_DISCIPLINA_CURSO INT,
PRIMARY KEY(CODIGO_PROFESSOR, SEQ_TURMA, SEQ_DISCIPLINA_CURSO),
FOREIGN KEY(SEQ_TURMA, SEQ_DISCIPLINA_CURSO) REFERENCES DISCIPLINA_TURMA (SEQ_TURMA,SEQ_DISCIPLINA_CURSO)
)

CREATE TABLE SEMESTRE (
SEQ_SEMESTRE INT PRIMARY KEY IDENTITY(1,1),
NOME_SEMESTRE VARCHAR(10)
)

CREATE TABLE DISCIPLINA_CURSO (
SEQ_DISCIPLINA_CURSO INT PRIMARY KEY IDENTITY(1,1),
FASE_DISCIPLINA_CURSO INT,
CODIGO_CURSO INT,
CODIGO_DISCIPLINA VARCHAR(10),
FOREIGN KEY(CODIGO_CURSO) REFERENCES CURSO (CODIGO_CURSO),
FOREIGN KEY(CODIGO_DISCIPLINA) REFERENCES DISCIPLINA (CODIGO_DISCIPLINA)
)

CREATE TABLE GRADE (
SEQ_GRADE INT PRIMARY KEY IDENTITY(1,1),
DIA_SEMANA_GRADE INT,
HORARIO_GRADE INT
)

CREATE TABLE GRADE_TURMA (
SEQ_TURMA INT,
SEQ_DISCIPLINA_CURSO INT,
SEQ_GRADE INT,
PRIMARY KEY(SEQ_TURMA,SEQ_DISCIPLINA_CURSO,SEQ_GRADE),
FOREIGN KEY(SEQ_TURMA, SEQ_DISCIPLINA_CURSO) REFERENCES DISCIPLINA_TURMA (SEQ_TURMA, SEQ_DISCIPLINA_CURSO),
FOREIGN KEY(SEQ_GRADE) REFERENCES GRADE (SEQ_GRADE)
)

ALTER TABLE PRE_REQUISITO ADD FOREIGN KEY(CODIGO_DISCIPLINA) REFERENCES DISCIPLINA (CODIGO_DISCIPLINA)
ALTER TABLE PRE_REQUISITO ADD FOREIGN KEY(CODIGO_DISCIPLINA_REQUISITO) REFERENCES DISCIPLINA (CODIGO_DISCIPLINA)
ALTER TABLE DISCIPLINA ADD FOREIGN KEY(CODIGO_DEPARTAMENTO) REFERENCES DEPARTAMENTO (CODIGO_DEPARTAMENTO)
ALTER TABLE DISCIPLINA_TURMA ADD FOREIGN KEY(SEQ_TURMA) REFERENCES TURMA (SEQ_TURMA)
ALTER TABLE DISCIPLINA_TURMA ADD FOREIGN KEY(SEQ_DISCIPLINA_CURSO) REFERENCES DISCIPLINA_CURSO (SEQ_DISCIPLINA_CURSO)
ALTER TABLE TURMA ADD FOREIGN KEY(SEQ_SEMESTRE) REFERENCES SEMESTRE (SEQ_SEMESTRE)
ALTER TABLE ESPACO_TURMA ADD FOREIGN KEY(CODIGO_ESPACO) REFERENCES ESPACO (CODIGO_ESPACO)
ALTER TABLE PROFESSOR_TURMA ADD FOREIGN KEY(CODIGO_PROFESSOR) REFERENCES PROFESSOR (CODIGO_PROFESSOR)
