# HelloRaye API Service Example

1.) To get started make sure you have .net core 5 SDK installed (hosting bundle is the best)
https://dotnet.microsoft.com/download/dotnet/5.0

2.) Want to learn more about .net 5 core? https://dotnet.microsoft.com/learn/aspnet/hello-world-tutorial/intro

3.) If you want to use an IDE download for free Visual Studio Community Edition: 
https://visualstudio.microsoft.com/vs/community/




The only code you will need to modify is ProductsControllers.cs

Replace this with your connection string
string sqlConnection = "Data Source=localhost;Initial Catalog=HelloRaye;Integrated Security=true;";


Replace this with your own custom query
string sqlQuery = "select Name as ProductName, " + // getting product name
    " 'category' as 'Seating'," + // hard code category example
    " 'subCategory' as 'Lounge Chair'," + // hard code subcategory example
    " case " +
    " when Grade = 1 then 'Residential'" + // getting grade:Residential with case
    " when Grade = 2 then 'Commercial'" + // getting grade:Commercial with case
    " end as Grade" +
    " from Products where ActivityState = 1";

run to test locally
"dotnet watch run"


When ready publish your app to AWS or Azure and share with Hello Raye to validate your payload.