﻿// See https://aka.ms/new-console-template for more information
using Haley.Models;
using Haley.Extensions;

Console.WriteLine("Hello, World!");

// ####### MS SQL

var cstr = $@"server=srv-db07;database=CDEToEngHub;uid=CDEUser;pwd=C3b%N7zQ1j@U5xK; TrustServerCertificate=True;";
var res = MssqlHandler.ExecuteReader(cstr, "SELECT name FROM master.dbo.sysdatabases", null).Result;
var result = res.Select(true).Convert(null);


// ####### MYSQL
//var cstr = $@"server=localhost;port=3306;database=accounts__;uid=root;pwd=";
//var res = MysqlHandler.ExecuteReader(cstr, "Show databases", null).Result;
//var result = res.Select(true).Convert(null);
//Console.WriteLine("End");


// ####### MARIADB
//var cstr = $@"server=localhost;port=4306;database=d_test;uid=root;pwd=";
//var res = MysqlHandler.ExecuteReader(cstr, "Show databases", null).Result;
//var result = res.Select(true).Convert(null);
//Console.WriteLine("End");

// ####### POSTGRESQL
//var cstr = $@"Host=localhost;Port=5432;Username=postgres;Password=;Database=di_schema"; 
//var res = PgsqlHandler.ExecuteReader(cstr, "select nspname as name from pg_catalog.pg_namespace where nspname not like 'pg_%'", null).Result;
//var result = res.Select(true).Convert(null);
//Console.WriteLine("End");