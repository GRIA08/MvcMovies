Riyanka Gandhi

2024-05-16
1335 UTC 

MvcMovies Site
Its just a practice tutorial followed using "https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-7.0&tabs=visual-studio"

1340 UTC
PART 1 
I have test the site just after creating 

1345 UTC
PART 2
New controllers are added as "HelloWorld.cs"
In this controller it defines functionalities:

1.Index - This is the default action method for controller also known as user requests the root URL of application.
Default Welcome Message: When user visit the main page of the website "http://localhost/HelloWorld" it shows messege "HELLO ! This is my first try..."
2.Message on specific URL - This action method is called when a user requests the URL 
When user visit a specific URL "http://localhost/HelloWorld/Welcome/" it shows a different message "This is second try ..."
3.In this third action method "HtmlEncoder.Default.Encode" ensures that HTML characters in the 'name' and 'ID' values are encoded to prevent cross-site scripting attacks.
The unnecessary comments and using statement have been removed for clarity. 
This 3rd action method doesn't work. While redirecting page to the specific URL it shows error message.
I have solved the error by editing default name value in "Program.cs" than I can able to redirect it to the specific URL "https://localhost:7253/HelloWorld/Try?name=RIYA&numtimes=10000" and shows message as "Hello RIYA, NumTimes is: 10000"
we can change parameters by editing name and numtimes

Tested and confirmed it runs successfully 

1349 UTC
PART 3
In Index file of view folder I replaced the heading form Welcome to MvcMovie

1350 UTC
Break Time

1400 UTC
Get back to work
Learn more about view in detail 

1500 UTC
Practical time

2024-05-20
1710 UTC
Practice more on View tutorial
Learn about how to set title, footer and menu link in the layout file.
Layout Files serve as a template for the web pages. They define the overall structure of the website, including elements thst appear on evry page. 
By including content section within yhe layout file, a new web pages that share the same basic structure but have unique content.
Title: The title is set within the head section of the layout file.
Footer: The footer content is usually placed within a dedicated section at the bottom of the layout file.
Here, copyright information or any other content can be add to display on all pages.
The navigation menu is often created using an unordered list (<ul>) within the layout file. Define list items (<li>) for each menu item and include anchor tags (<a>) to specify the link URL and text.

1742 UTC
Add Image to display on website.
Also use width and height tag to adjust the image size. 
In Index.cshtml I added content to display on the site such as Title, message and include img tage to preview the image on the site.

1750 UTC 
ERROR!! 
It shows the icon of image is there but can't preview.
After try some possible solutionals it works.
I forgot to includ "alt" in image tage with was causing the eeror so now it has resolved.

1820 UTC 
"https://localhost:7253/HelloWorld"
It works successfully with and also shows the image the I have included

2024-05-21
1152 UTC
PART 4
Add a model 
To practice models I have added a class in Model folder called "Movie.cs"
In this class I have add a code with defines movie entry in a database or application
class defination: It creates a blueprint names Movie that can be used to create objects representing indiviual movies.
properties: The class defines several properties like Id, Title, ReleaseDate, Genre, and Price.
These properties act like lables for stroring information about a movie.
Data Types:
int for Id likely holds a unique identification number for the movie.
string? for Title and Genre allows storing text data, and the ? indicates these might be nullable (can be empty).
DateTime for ReleaseDate stores the date the movie was released.
decimal for Price stores the movie's price, likely with decimals.
Data Annotation: The [DataType(DataType.Date)] attribute on ReleaseDate suggests this property should be treated as a date for data entry purposes

1227 UTC
Scaffold movie pages
Now we will learn about scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for the movie model.

How to add Scaffold (from the tutorial of learn Microsoft PART 4)

In the Add New Scaffolded Item dialog:
In the left pane, select Installed > Common > MVC.
Select MVC Controller with views, using Entity Framework.
Select Add.
Complete the Add MVC Controller with views, using Entity Framework dialog:

In the Model class drop down, select Movie (MvcMovie.Models).
In the Data context class row, select the + (plus) sign.
In the Add Data Context dialog, the class name MvcMovie.Data.MvcMovieContext is generated.
Select Add.
In the Database provider drop down, select SQL Server.
Views and Controller name: Keep the default.
Select Add.

Scaffolding add packages which add packages like 
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Microsoft.VisualStudio.Web.CodeGeneration.Design

It creates the movie controller "MoviesController.cs"
Also Razor view files for Create, Delete, Details, Edit and the index pages "Views/Movies/*.cshtml" and a database context class: "Data/MvcMoviesContext.cs"

In addition it upadtes required packages, registers and add databases automatically.

1245 UTC

Use the EF Core Migrations feature to create the database. Migrations is a set of tools that create and update a database to match the data model.
From the Tools menu, select NuGet Package Manager > Package Manager Console .
In the Package Manager Console (PMC), enter the following commands:
>Add-Migration InitialCreate
>Update-Database

Add-Migration InitialCreate: Generates a Migrations/{timestamp}_InitialCreate.cs migration file. 
The InitialCreate argument is the migration name. Any name can be used, but by convention, a name is selected that describes the migration. 
Because this is the first migration, the generated class contains code to create the database schema. The database schema is based on the model specified in the MvcMovieContext class.
i.e "20240527202822_InitialCreate.cs" and "MvcMovieContextModelSnapshort.cs"

Update-Database: Updates the database to the latest migration, which the previous command created. 
This command runs the Up method in the Migrations/{time-stamp}_InitialCreate.cs file, which creates the database.

In the Controllers/MoviesController.cs file, the constructor uses Dependency Injection to inject the MvcMovieContext database context into the controller.
The database context is used in each of the CRUD methods in the controller.
Scaffolding generated in Program.cs
"builder.Services.AddDbContext<MvcMovieContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcMovieContext")));"

It has also added connecting strings to appsetting.json file.

In ASP.NET MVC, strongly typed models and the @model directive are used to improve code safety and readability.

Strongly typed models: Represent data passed between controllers and views. They enforce data types, preventing errors.

@model directive: Used in views to specify the expected model type. This allows using the model's properties directly in the view.

Benefits:

Compile-time type checking: Catches errors early during development.
Intellisense support: Provides code completion and suggestions in the view.
Clearer code: Makes code easier to understand and maintain.

2024-05-23
1424 UTC
PART 5 
I created new class named SeedData in the Model folder.
Seed data in Visual Studio ensures consistent, reproducible testing, facilitates development, provides realistic demo data, maintains data integrity, supports automated processes, and aids in performance testing with predefined datasets.

2024-05-27
2032 UTC 
PART 6
Then I have edited Models/Movies.cs 
Then I define a Movie class with attributes for Id, Title, Release Date, Genre, and Price, using DataAnnotations to specify display names and data types.
i.e [Display(Name = "Release Date")] shows "Release Date" instead of "ReleaseDate", and [Column(TypeName = "decimal(18, 2)")] ensures the Price is correctly in the database.

The Edit, Details, and Delete links are generated by the Core MVC Anchor Tag Helper in the Views/Movies/Index.cshtml file.
In this file, the AnchorTagHelper dynamically generates the HTML href attribute value from the controller action method and route id. 
the second Edit action method is preceded by the [HttpPost] attribute.

2056 UTC
PART 7
In this section we have updated Index method in MoviesController.cs
Index action method creates a LINQ query to select the movies
s => s.Title!.Contains(searchString) in code is a Lambda Expression. 
Lambdas are used in method-based LINQ queries as arguments to standard query operator methods such as the Where method or Contains. LINQ queries are not executed when they're defined or when they're modified by calling a method such as Where, Contains, or OrderBy.
Now we can search th title of the movies using search option too.

2103 UTC
Another method is add for the search using gener. Then updated Index methos .cshtml in Views/Movies.
"2024527223559_Rating.cs" has added.

Added successfully and it works smoothly.

2024-05-30
1026 UTC
PART 8 
In this part I have added Rating property to models.
Because I have added a new field to the Movie class, I need to update the property binding list so this new property will be included.
In MoviesController.cs, update the [Bind] attribute for both the Create and Edit action methods to include the Rating property
[Bind("Id,Title,ReleaseDate,Genre,Price,Rating")]

Updated the view templates in order to display, create, and edit the new Rating property in the browser view.
Also Updated the /Views/Movies/Create.cshtml with a Rating field.

1037 UTC 
From package manager console I have added Migration Rating and than updated the database.

RUN the web to confirm the successsfull compilation. Works perfectly!

1044 UTC 
Then I have added Validation rules to the movie model 
i.e By editing required and other validation like Minimumlenght, stringlenght and all
Now I verify the added rule and its a success.

AND HERE WE HAVE COMPLETED THE TUTORIAL FOR THE WEB DEVELOPMENT SUCCESSFULLY

2024-06-06
1420 UTC
In previous lecture we have created the github account.
Today we have created github repositery and push the code on github account.
During this process we need to authenticat from our github account to push the code 
