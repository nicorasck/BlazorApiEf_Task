Skapa ett nytt Blazor WASM Standalone projekt (använd .NET 8).

OBS! Detta projekt är ett test med BlazorServer .Net7.0.0
________________________________________________________

Konfigurera infrastrukturen för Entity Framework Core.

Entitet: User

Id
Username
Email
List
Entitet Blogpost

Id
Title
Content
Created
AuthorID
User Author
User har alltså en lista av objekttypen BlogPost. Blogpost har AuthorId och Author som är avtypen User.

Ladda hem samma nuget-paket vi använde i början av kuursen, Core, Tools, Design. SQlite och konfigurera EF-core.

Ni behöver registrera ern DB-Context klass som en tjänst i er program.cs:

builder.Services.AddDbContext<Klassen för er DbContext>(options => options.UseSQlite("Data Spourse=Eran path till DB-filen\sysdb.db"));

Glöm inte sen att migrera pch uppdatera.
