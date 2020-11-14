# Architecting-Xamarin.Forms-Applications-for-Code-Reuse
Pluralsight 'Architecting Xamarin.Forms Applications for Code Reuse' Course Repository

![final project architecture](https://github.com/VeselinovStf/Architecting-Xamarin.Forms-Applications-for-Code-Reuse/blob/main/repoImg/demo.bmp)

## Course Info

- A well-architected application is flexible to changing business requirements. This course will teach you how to architect Xamarin.Forms applications in a way that promotes reusable patterns.

- As business requirements change, so do solution assumptions. In this course, Architecting Xamarin.Forms Applications for Code Reuse, you’ll learn different architectural patterns in Xamarin.Forms. First, you’ll explore project structure and organization. Next, you’ll discover patterns and standards to promote code sharing. Finally, you’ll learn how to utilize dependency injection in Xamarin.Forms. When you’re finished with this course, you’ll have the skills and knowledge of architecting Xamarin.Forms projects needed to optimally promote code reuse.

## Pluralsights 'Building Cross-platform Apps with Xamarin Forms' Path
- At its simplest, Xamarin.Forms is a mobile application framework for building user interfaces.

## Intermediate Course
- Take a deeper dive into Xamarin.Forms while you learn about data binding, responsive layouts, deployment and more advanced techniques.

### Content

1. Course Overview
2. Solution Structures
3. Common Code

### Project Building Info

2. Solution Structures
	- Creating src/ folder to solution - All code specific to project is going to be stored there
	- Creating sln Folders for all platform specific app - In order to add new futures saparated at sln-level
	- Create src/Description project - Storing all modeling and interfacing
	- Create src/Data Access project - Customer DAL
	- Create src/Service project - Customer SL
	- Create View Models to consume this layers

3. Common Code
	- DI Create Dependency Injection Project
	- DI Add TinyIoC
	- DI Extract and Refactor Classes
	- DI Wireup DI
	- Cross-platform Create Interface - IPlatformPrinter
	- Cross-platform Implement Platform Service
	- Cross-platform Utilize Dependency Service

#### Duration: 1h 2m

### Status

- Completed
