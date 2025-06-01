# C# 13 and .NET 9 Learning RepositoryU

This repository was created as part of my journey to learn **C# 13** and **.NET 9**, using the book [*C# 13 and .NET 9 – Modern Cross-Platform Development Fundamentals*](https://www.amazon.com/13-NET-Cross-Platform-Development-Fundamentals/dp/183588122X) as the primary guide

## Learning Goals:
* Complete the book by the end of 2025
* Dedicate at least two ours per day to:
	* Reading
	* Researching related topics
	* Implementing code examples
	* Applying the knoledge through experimentation

## Repository purpose
This is a learning-focused repositoryr, so:
* No formal project structure is enforced
* No stric architectural patterns or best practices are guaranteED (since I'll be learning another programing language, I'll be focusing on the basics)
* The goal is experimentation, understanding, and prectice, not production-level code

## Notes!
Bellow I'll save alooooot of notes of the book, code, implementations, and anything related during this learning journey!!

- We can compile C#, F# and VB to Common Intermediate Language (CIL) then Common Languagem Runtime and after machine code. Since
these three are compiled to the same CIL, e can build .NET projects with anyone of them

.NET environment:
* .NET Framework:
	*	Legacy, monolithic and Windows-only: Was created to work exclusively on windows environment, and in it we had tecnologies like
		*ASP.NET MVC* (earlier versions like ASP.NET MVC 5),, which, although robust, were tight coupled with windows ecosystem
* .NET Core
	*   Multi-platform and with better performance: It arose to meet  the need for a modern, cross-platform, and modular environment. .NET Core brought significant performance improvements and allowed applications to run on different operation systems like Linux and MacOS
* .NET 5+
	* Unification of .NET ecosystem: Starting with .NET 5, Microsoft dropped "Core" from the name to signal that the modern platform unified the experiences of .NET Core and other implementations
    * Inclusion of ASP.NET Core (and ASP.NET Core MVC): In this unified environment, ASP.NET Core is already integrated with the MVC pattern (alongside other approaches like Razor Pages and APIs). This means that when developing a modern web application with .NET 5 or later, you're already using the most up-to-date and optimized version of MVC — namely, ASP.NET Core MVC — without needing to install a separate component.
