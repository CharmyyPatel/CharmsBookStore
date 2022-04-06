Hello!

2234
Successfully created default Application.

2251
Pretty quick this time....!! Successfully added theme and dropdown to the navbar 
Now, heading towards adding projects

2318
Added all 3 projects and ran the application. Thankfully this time I got 0 errors in one go...!!

1231
Finally done with the Part1 of Assignment2 

====================================================================================================
************************************** Assignment 2 - Part 2 ***************************************
====================================================================================================
Date: 1st April
2358
Created Migrations.. 
Entry of the Migration file "20220402035636_AddDefaultIdentifyMigration.cs"		

Date: 4th April
2256 
Finally solved all the errors in CharmsBooks.DataAccess file

2325
Added new Class file to CharmsBooks.Models named as Category.cs 

0224
Created Repository folder, IRepository and interfaces and classes for the application.
Got few errors but they got resolved quickly. 
Was so into following the steps and solving errors that forgot to commits everything on github.

Its 5th April and I Slept at 4 but as usual forget to add the instances in the READme and also forget to commit changes and went on job
But still lucily all the changes were found as they were when opened Visual Studio 2019 again.

Date 5th April
1831 
Did IUnitOfWork.cs and UnitOfWork.cs and got 2 errors as follows.

1st error:
Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0053	Inconsistent accessibility: property type 'ICategoryRepository' is less accessible than property 'UnitOfWork.Category'	CharmsBooks.DataAccess	C:\Users\Admin\source\repos\CharmsBookStore\CharmsBooks.DataAccess\Repository\UnitOfWork.cs	19	Active

2nd error:
Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0019	Operator '==' cannot be applied to operands of type 'object' and 'int'	CharmsBooks.DataAccess	C:\Users\Admin\source\repos\CharmsBookStore\CharmsBooks.DataAccess\Repository\CategoryRepository.cs	24	Active

2252
Got this error in startup.cs file at line 38 "services.AddScoped<IUnitOfWork, UnitOfWork>();"