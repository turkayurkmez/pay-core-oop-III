﻿// See https://aka.ms/new-console-template for more information
using Bridge;

Console.WriteLine("Hello, World!");



//                              RAPOR
//        Satis                                Performans
// PDFSatis HTMLSatis  ExcelSatis     PDFPerf   HTMLPerf    ExcelPerf 
//
// 
/*
 *        Rapor                              Format
 *           +Format .....................> 
 *   Satis   Performans                    PDF  HTML EXCE
 *     
 */

SalesReport salesReport = new SalesReport();
salesReport.Format = new Pdf();