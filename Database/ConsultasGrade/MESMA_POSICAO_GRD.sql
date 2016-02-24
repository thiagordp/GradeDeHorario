  SELECT * FROM DISCIPLINA_TURMA AS DISC_TRM
  INNER JOIN GRADE_TURMA AS GRD_TRM
  ON DISC_TRM.SEQ_DISCIPLINA_TURMA = GRD_TRM.SEQ_DISCIPLINA_TURMA
  WHERE DISC_TRM.CODIGO_TURMA='01652' AND
  DISC_TRM.CODIGO_DISCIPLINA = 'ARA1879' AND
  DISC_TRM.SEQ_SEMESTRE = 9 AND
  GRD_TRM.DIA_SEMANA_GRADE = 1 AND
  GRD_TRM.HORARIO_GRADE = 1
