# BookmakerServer
A simple server for performing bookmarking of data collected from git repository search.

# Technical requirements
.Net Framework 4.7

# Description
A simple server implemeted with WEB API 2. Supports cors, data validation and session.

API :
Has only 1 controller (Bookmark). 
For Bookmarking use:

POST :[server_root]/api/bookmark

Model:
Recieves as parameter
{"id":int,"name":string ,"avatar": url (string),"identifier": string representing unique identifier}

Implemented in /Models/BookmarkRequest.cs

Response: HttpResponseMessage.

------------------------------------

Data storage:

For each unique user represented by identifier field, stores dictionary of data where key is a unique identifier of repository and value is an object with name and avatar(url) properties.

---------------------------------------

For session support in api see /SessionHelpers and WebApi.config Register.

# Note
Possibly a better sollution was to use MVC project with api controller.
The solution has only one layer (no BLL, DAL or etc). 

