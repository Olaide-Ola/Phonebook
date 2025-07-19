# PhoneBook Console Application
A simple, console-based phonebook application built with C# (.NET) to store and manage contacts.
## Features
- Add Contacts: Store new contacts with name and phone number
- View Contacts: Display all contacts or search for specific ones
- Edit Contacts: Update existing contact information
- Delete Contacts: Remove contacts from the phone book
- Search Functionality: Find contacts by name or phone number
- ## Prerequisities
- .NET 6.0 SDK
- Visual Studio 2022 or Visual Studio Code
- ## Installation
1. Clone the repository
```
git clone https://github.com/Olaide-Ola/Phonebook.git
```
2. Navigate to the project directory
```
cd Phonebook
```
3. Restore dependencies
```
dotnet restore
```
4. Build the project
```
dotnet build
```

## Usage
1. Run the application
```
dotnet run
```
2. Follow the on-screen menu to navigate through the application:
* Add a New Contact
* View all Contacts
* Delete a Contact
* Update an Existing Contact
* Search for Contacts by matching names
* Search for contacts using phone number
* Exit
## Project Structure
```
|__	Contacts/					# Core domain logic
	|__	Interface/
		|__	IContactServices.cs		# Abstraction contracts
	|__	Model/
		|__	Contact.cs			# Contact data model
	|__	Services/
		|__	ContactServices.cs		# Logic class
|__	Phonebook/
	|__	Program.cs				# Main application entry

		
		
	