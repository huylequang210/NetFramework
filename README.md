# NetFramework

In Package Manager Console:
1. Choose DAL project
2. Run Enable-Migration
3. Run Add-Migration Initial
4. Run Update-Database

App.config:
```
<connectionStrings>
  <add name="BenhNhanContext"
    connectionString="data source=.\SQLEXPRESS;initial catalog=BenhNhanContext;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"
    providerName="System.Data.SqlClient"/>
</connectionStrings>
```
