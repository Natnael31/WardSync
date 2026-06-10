# WardSync

Section 8 - CSE 325


*James Eberhard

*Kim Kathleen Bown

*Jean Rubin Oxeant

*Mario Leo Junior Meza Mancilla

*Daniel 'Ezra' Rivera

*Charles Hemedi

*Natnael Gashaw

Passwords for demonstration purposes:

Username: admin@wardsync.com  Password: Admin123!

Username: leader@wardsync.com	Password: Leader123!

Username: viewer@wardsync.com	Password: Viewer123!

# Overview

WardSync is a church leadership app designed for ward and branch leaders to organize callings, assignments, service needs, and follow-up tasks in one place. Leaders can track who is assigned, what needs to be done, due dates, progress, notes, and completion status. The goal is to help bishoprics, branch presidencies, auxiliary leaders, and ward councils keep important responsibilities from getting lost in texts, meetings, or memory.


# The Problem It Solves
In a ward or branch, leaders often have a lot of moving pieces to manage at the same time. There are callings, releases, sustaining dates, service needs, youth activities, ministering follow-up items, interviews, meeting action items, and assignments from ward council. It is easy for something important to get lost if it only lives in a text thread, a notebook, or someone’s memory.
WardSync would give leaders a simple place to see what is open, who is assigned, what is overdue, and what has already been completed. The goal is not to replace official Church tools.


# Web Pages

The web application consists of several pages that work together to support communication, task management, and reporting. Each page has a specific purpose, and the application transitions between pages through the navigation menu and user actions after login.

- Home page 

The Home Page is the public landing page of the application. It introduces the system and provides general information to visitors before they log in.

    
- Dashboard
Users will be able to see a quick overview of open, completed, and overdue items. 

-   Calling 
    The Calling page is used to manage and track callings of different members, organization.. Users can transition to this page from the dashboard or navigation menu.

    This page dynamically creates and displays calling records, including details such as member information, calling status, notes, or family visit history. 


-   Assignments
    The Assignments page is used to manage tasks and responsibilities assigned to members or staff. Users can navigate to this page from the dashboard or menu options.

    The page dynamically generates assignment lists, task descriptions, due dates, assigned users, and progress updates. As new assignments are created or updated, the page automatically refreshes the displayed information.

-   Follow-up
    The Follow-up page allows users to track ongoing actions and monitor pending items. Users access this page through the application menu.

    Dynamic content on this page includes follow-up records, status updates, deadlines, notes, and reminders. Information displayed changes based on recent updates and user input.

-   Members
    The Member's page is designed to manage member information and profiles. Navigation to this page occurs through the main menu after authentication.

    The page dynamically displays member data such as names, contact information, calling, status, and participation records. When members are added, updated, or removed, the content updates automatically in the system.

-   Reports
    The Reports page provides analytical information and summaries generated from system data. Users can move to this page from the dashboard or navigation bar.

    This page dynamically generates reports, charts, summaries, and filtered data based on user requests or stored information. Reports update automatically to reflect the most recent system activity.

-   Registration
    The Registration page allows new users to create an account in the application. 


-   Login
    The Login page is the entry point of the application where users authenticate using their credentials. After successful login, the application will transition to the Dashboard.


# Application Navigation and Transitions

    The application transitions between pages using a navigation menu and user actions. A new user first accesses the Registration page to create an account, then moves to the Login page. After authentication, users are redirected to the Home page (Dashboard). From the dashboard, users can access Calling, Assignments, Follow-up, Members, and Reports pages. Each page dynamically updates information from the database, ensuring users always interact with current and relevant data.


# Development Environment

Several tools were used during the development of the software to support coding, collaboration, database management, and project organization.

- Visual Studio Code

We used Visual Studio Code (VS Code) as the primary development environment for writing and editing code. VS Code provided useful features such as syntax highlighting, debugging tools, extensions, version control integration, and code suggestions, which helped improve development efficiency and organization.


# GitHub Repository Setup and Running the Program

To collaborate on the project, we created a GitHub repository where all members of the group could access and contribute to the software. Each member cloned the repository to their own computer using Visual Studio Code.

Cloning the Repository

Follow these steps to clone the repository:

1. Go to the GitHub repository: https://github.com/jneberhard/WardSync
2. Click the green Code button and copy the repository link.
3. Open Visual Studio Code.
4. Click Clone Git Repository.
5. In the search bar, select Clone from GitHub or paste the repository link directly.
6. Paste the copied repository link.
7. Choose a folder on your computer where the project will be stored.

# Restore Packages

Restoring the required NuGet packages.

Open a terminal in the project folder and run:

dotnet restore

This command installs all dependencies required for the application.


# Running the Program

To run the application locally, follow these steps:

1. Open Terminal in Visual Studio Code and select New Terminal.
2. Type the following command:
    dotnet build,
    dotnet run
3. Wait for the application to build and start running.
4. Locate the local HTTP link generated in the terminal (for example, localhost).
5. Copy and paste the link into your preferred web browser to launch the application.

This process allows each team member to run and test the web application locally on their own machine during development.

- ... Database

Database setup will be updated once finalized.


- Trello
Trello was used as a project management and planning tool to organize tasks and track project progress. We used boards, lists, and cards to assign responsibilities, monitor deadlines, and manage software development activities. Trello helped improve team communication and ensured that development tasks were completed in an organized manner.

Trello link: https://trello.com/b/UkTMelSr/wardsync



# Programming Language and Libraries Used

The software was developed using the C# programming language within the .NET framework. C# was selected because it provides strong support for building secure, scalable, and modern web applications. It also offers object-oriented programming features that help organize code, improve maintainability, and support efficient application development.

- C# and .NET

C# was the primary programming language used to develop the application. The .NET platform provided the runtime environment and framework needed to build, run, and manage the software. Using .NET allowed us to structure the application efficiently, manage data processing, and implement business logic in a reliable way.

- ASP.NET

ASP.NET was used to build the web application and manage server-side functionality. It helped handle routing, authentication, data processing, and communication between the frontend and backend. ASP.NET also made it easier to create dynamic web pages and manage user interactions within the system.

- .NET Blazor

.NET Blazor was used to create the user interface of the application. Blazor allowed us to build interactive web pages using C# instead of JavaScript. It enabled the creation of reusable components, dynamic page updates, and responsive user interactions while maintaining consistency throughout the application.

- Libraries and Framework Support

The application also used built-in .NET libraries to support common tasks such as data handling, authentication, page rendering, and communication between application components. These libraries improved development speed and reduced the need to create functionality from scratch.

# Final video

{xxPlace the final video link here:}


# User Guide
This guide explains how to access the system and use its main features.

- Logging In
1.	Open the WardSync website in your web browser.
2.	Click the Login button on the home page.
3.	Enter your registered email address and password.
4.	Click Sign In.
5.	After successful authentication, you will be redirected to the Dashboard.
If you do not have an account, select Register and complete the registration form before logging in.

- Using the Dashboard
The Dashboard provides an overview of important ward information.

Dashboard Features
1. 	View pending assignments.
2.	View overdue assignments.
3.	View open callings.
4.	Access quick links to manage callings and assignments.
5.	Receive notifications and reminders for important tasks.

Navigation
Use the navigation menu to access:
1.	Dashboard
2.	Callings
3.	Assignments
4.	Reports
5.	Logout

Managing Callings
The Callings section allows leaders to track ward positions and assignments.
View Callings
1.	Select Callings from the navigation menu.
2.	Review the list of current callings.
3.	Use search or filtering options if available.

Add a Calling
1.	Click Add Calling.
2.	Enter the calling title and description.
3.	Assign a member if applicable.
4.	Save the record.

Edit a Calling
1.	Locate the calling in the list.
2.	Click Edit.
3.	Update the information.
4.	Click Save Changes.

Remove a Calling
1.	Select the calling to remove.
2.	Click Delete.
3.	Confirm the deletion when prompted.

Managing Assignments
The Assignments section helps leaders organize and track responsibilities.

View Assignments
1.	Open the Assignments page.
2.	Review all current assignments and their statuses.

Create an Assignment
1.	Click New Assignment.
2.	Enter the assignment details.
3.	Assign it to a member.
4.	Set a due date.
5.	Click Save.

Update an Assignment
1.	Select an assignment from the list.
2.	Click Edit.
3.	Modify the details or status.
4.	Save the changes.

Complete an Assignment
1.	Open the assignment.
2.	Change its status to Completed.
3.	Save the update.

Delete an Assignment
1.	Select the assignment.
2.	Click Delete.
3.	Confirm the action.

Viewing Reports
The Reports section provides information about ward activities and progress.

Available Reports
1.	Assignment Status Report
2.	Overdue Assignment Report
3.	Open Callings Report
4.	Member Participation Report

Generate a Report
1.	Navigate to Reports.
2.	Select the desired report type.
3.	Choose any available filters or date ranges.
4.	Click Generate Report.
Review Results

Reports display relevant data in a table or summary format that can be used for leadership meetings and planning.

Logging Out
To securely exit the system:
1.	Click Logout in the navigation menu.
2.	Confirm the action if prompted.
3.	You will be returned to the home page.
Always log out when using a shared or public computer.

Troubleshooting
Unable to Log In
1.	Verify your email address and password.
2.	Ensure your account has been registered.
3.	Contact an administrator if the issue persists.

Missing Data
1.	Refresh the page.
2.	Confirm that the data was saved successfully.
3.	Check your internet connection.

Application Errors
1.	Sign out and sign back in.
2.	Refresh the browser.
3.	Contact the system administrator for assistance.

Thank you for using WardSync. The system is designed to simplify ward leadership administration and improve assignment tracking and reporting.

