# WindowsFormApp_TestsDb
this application allow to create, edit and pass tests;

Select the folder which include the db.accdb file. 
You should change the path to db.accdb file: go to App.config file and change the 5th line: 

<add name="Connection" connectionString="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\db.accdb;

Write Data Source=[path to db]\db.accdb;
