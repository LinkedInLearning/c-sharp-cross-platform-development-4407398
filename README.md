# C# Cross-Platform Development
This is the repository for the LinkedIn Learning course C# Cross-Platform Development. The full course is available from [LinkedIn Learning][lil-course-url].

![C# Cross-Platform Development][lil-thumbnail-url] 

In this course, learn the fundamentals of building cross-platform C# apps that work on Android, macOS/iOS, and Windows while leveraging .NET MAUI. Instructor Jesse Freeman shows you core concepts like setting up a cross-platform dev environment, building simple UI, navigating between app screens (pages), and implementing MVVM concepts with data binding XAML. Follow along with Jesse as he shows you how to apply what you’ve learned toward creating a simple note-taking app, and covers the skills you need to know to get started building cross-platform C# apps on your own.

## Instructions
This repository uses a branch structure to correspond with different lessons in the course. The branches are named in the format `lesson-CHAPTER#.MOVIE#`, where CHAPTER# is the chapter number and MOVIE# is the video number in that chapter. You can switch to a specific branch using the branch pop-up menu in GitHub or by adding `/tree/BRANCH_NAME` to the URL.

When switching from one exercise files branch to the next after making changes to the files, you may get a message like this:

    error: Your local changes to the following files would be overwritten by checkout:        [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

To resolve this issue:
	
    Add changes to git using this command: git add .
    Commit changes using this command: git commit -m "some message"

## Branches
- `lesson-1.2`: Covers installing .NET 7 SDK and creating a .NET Core application.
- `lesson-2.2`: Involves creating the Note model and database context.
- `lesson-2.3`: Establishes the SQLite database connection and implements the 'List Notes' command.
- `lesson-3.1`: Implements the 'Create Note' command and handler.
- `lesson-3.2`: Implements the 'Read Note' command and handler.
- `lesson-3.3`: Implements the 'Update Note' command and handler.
- `lesson-3.4`: Implements the 'Delete Note' command and handler.
- `lesson-4.1`: Introduces the implementation of note search functionality.

## Installing
1. To use these exercise files, you must have the following prerequisites:
    - Basic understanding of C# programming and its syntax, including variables, loops, conditionals, and functions.
    - Familiarity with object-oriented programming concepts such as classes and inheritances.
    - Basic understanding of databases, particularly relational databases.
    - Knowledge of LINQ (Language Integrated Query) for querying data in C#.
    - Experience with console applications and the command line.
2. Clone this repository into your local machine using the terminal (Mac), CMD (Windows), or a GUI tool like SourceTree.
3. Follow the course-specific instructions provided in the course.



### Instructor

Jesse Freeman 
                            


                            

Check out my other courses on [LinkedIn Learning](https://www.linkedin.com/learning/instructors/jesse-freeman).

[lil-course-url]: https://www.linkedin.com/learning/c-sharp-cross-platform-development?dApp=59033956&leis=LAA
[lil-thumbnail-url]: https://media.licdn.com/dms/image/D560DAQFN2A5GUfqgSw/learning-public-crop_288_512/0/1691011036247?e=2147483647&v=beta&t=mbFx4b-JokKdQ1t-OqvBE-tL3_Gg9FEsg7a-1CxfOrM
