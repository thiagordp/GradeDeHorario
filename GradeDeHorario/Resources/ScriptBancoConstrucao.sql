USE [master]
GO

/****** Object:  Database [GradeHorario]    Script Date: 13/01/2016 21:45:49 ******/
CREATE DATABASE [GradeHorario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GradeHorario', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\GradeHorario.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GradeHorario_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\GradeHorario_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO