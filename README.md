To start the app, run first the following:

For MahawMedicineAPI:

1) Run the following in the terminal (ensure that you run it inside the MedicineAPI folder):
```
dotnet build
dotnet ef migrations add InitialCreate
dotnet ef database update
```
2) Then run the server:
```
dotnet run
```
3) Make sure the API stays running.

Lastly, you can now run the frontend web app (ensure again that it is the MedicineApp folder):
```
dotnet run
```
