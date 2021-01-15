# Pierre's Sweet & Savory Treats

#### _This is a web app with user authentication and a many-to-many relationship.  1/15/2021_

#### By _**Constantine Yakubovski**_ 

## Description 

* The application have user authentication
* A user will be able to log in and log out
* Only logged in users will have create, update and delete functionality
* All users will able to have read functionality
* There is a many-to-many relationship between Treats and Flavors
* A user will able to navigate to a splash page that lists all treats and flavors
* Users will be able to click on an individual treat or flavor to see all the treats/flavors that belong to it

## Installation Requirements

- Install [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391)
- Install [MySQl](https://dev.mysql.com/downloads/file/?id=484914)
- Install [.Net Core](https://dotnet.microsoft.com/download/dotnet-core/2.2)
- Install [Visual Studio Code](https://code.visualstudio.com/)
- Install [Git](https://git-scm.com/downloads/)

## Setup
In the Terminal
-  `$ cd ~` - it will navigate to the user's home directory
-  `$ cd desktop`- it will navigate to the desktop
-  `$ git clone` ,then copy/paste https://github.com/faustlarsen/Pierre , then press 'enter' - it will create the file on the desktop
-  `$ cd Pierre` - it will enter the folder
-  `$ code .` - it will launch VSCode ( text editor ) to open the file
-  `$ touch appsettings.json` - create this file in root directory
- Copy and paste in appsettings.json file: 

```
{
  "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=pierre;uid=root;pwd=YourPassword;"
  }
}
```
- Replace 'YourPassword' with MySQL password that was set during installation of MySQL.
- `$ dotnet restore`

## DATABASE SETUP 
Copy and Paste the following commands in the terminal. (exclude '$' and '>')
-  `$ mysql -uroot -pepicodus ` - start MySQL Server 
-  `$ cd ~` - it will navigate to the user's home directory
-  `$ cd desktop`- it will navigate to the desktop
-  `$ cd Pierre` - it will enter the folder
-  `$ dotnet ef database update` - it will generate database
- `> exit ` - to exit MySQL
- `$ dotnet restore ` - it will complie the code
- `$ dotnet run ` - it will launch the app 
- Then in console click on (localhost:5000) to view the app in the browser

## ALTERNATIVE DATABASE SETUP
- `$ mysql -uroot -pepicodus` - start MySQL Server 
- Open MySQL Workbench
- Choose 'Administration'
- Then 'Data Import'
- Choose  'Import Self-Contained File"
- In browsing tool to select the pierre.sql file that is in the project
- Start Import

## ALTERNATIVE DATABASE SETUP
- `$ cd desktop`- it will navigate to the desktop
- `$ cd pierre` - it will enter the working folder
- `$ cd pierre` - it will enter the main project
- `$ dotnet ef migrations Initial` - will create database on MySQL Workbench
- `$ dotnet ef database update` 
- `$ dotnet run ` - it will launch the app in (localhost:5000)


## Known Bugs


## Support and contact details

__faustlarsen@gmail.com__

## Technologies Used

-  _C#_

-  _ASP.NET_

-  _MVC_

-  _My SQL_

-  _HTML_

- _Entity_

-  _Written in VS Code_

### License

This software is licensed under the MIT license

Copyright (c) 2020 **_Constantine Yakubovski_**