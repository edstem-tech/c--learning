﻿using BankStatementAnalyzerOops;
using BankStatementAnalyzerOops.Impl;


var csvParser = new BankStatementCsvParser();
var analyzer = new BankStatementAnalyzer(csvParser);
analyzer.Analyze(@"../../../Data/test.csv");

// analyzer = new BankStatementAnalyzer(new BankStatementXlsParser());
// analyzer.Analyze(@"../../../Data/test.xls");