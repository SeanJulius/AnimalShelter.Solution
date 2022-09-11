## AnimalShelter

#### By _**Sean Julius**_


## Technologies Used

* _C#_
* _MySQL_
* _MySQL Workbench_
* _.NET 5 SDK_
* _Git BASH_
* _ASP .NET CORE MVC_
* _Entity Framework Core_
* _Identity_

## Setup/Installation Requirements

1. Download or clone `https://github.com/SeanJulius/AnimalShelter.Solution.git` to your local machine

2. Open terminal and navigate to the `AnimalShelter.Solution` of the directory

3. In the the `AnimalShelter` directory, install dependencies by running command:
`$ dotnet restore`

4. Create your database- this can be done by using Migrations
  - first, you'll need to create an appsettings.json file in the `AnimalShelter` directory
    - add the following code to the file:
```
{
  "ConnectionStrings":
  {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd={YOUR_PASSWORD};"
  }
}
```
Be sure to replace  `{YOUR_PASSWORD}` with the appropriate terms.
- for `{animal_shelter}`, this refers to the database or schema
  - make sure to replace this input with what you decide to name the schema/database
- for `{YOUR_PASSWORD}`, this refers to your password for MySQL

- NOTE: _Do not include the curly brackets in your code snippet of appsettings.json_

  - in order to use a migration, first make sure you download "dotnet ef" tool by running `dotnet tool install --global dotnet-ef --version 3.0.0`
  - next make sure you are in the `Bakery` directory, and run `dotnet ef migrations add Initial`
    - this will create a new `Migrations` folder in the root of that directory
  - Finally, to apply the migration, run `dotnet ef database update`
    - this will actually create the database in MySQL so you don't have to manually create it yourself!


5. In order to see the website in the browser, make sure you've navigated to the `AnimalShelter` diretory
  - run the code `dotnet run`
6. View the website by entering `localhost:5000/` in the url of your browser/client 

## Bugs

_Views running an error for not being recognized._

## License

_Copyright (c) 2022 Sean Julius Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._



## Description

_This project is used to send requests through an API inregards to an Animal Shelter that lists animals currently present._