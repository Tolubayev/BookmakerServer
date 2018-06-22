# BookmakerServer
A simple server for performing bookmarking of data collected from git repository search.

# Technical requirements
Windows 10, VS 2017, .Net Framework 4.7. 

# Clone / run

1. clone repository:

```
git clone https://github.com/Tolubayev/BookmakerServer.git
```

2. open solution file in VS 2017:

```
[root]\BookmakerServer\Exam.sln
```
3. Restore nugets with NuGet manager

4. Run locally [F5]


Expected:
Browser should open swagger page of the api. For instance [http://localhost:57358/swagger/ui/index]

One may perform calls from swagger or/and to use Githubsearcher application. See:
https://github.com/Tolubayev/GithubSearcher.
This is a standalone react app.

You may also deploy the api to ISS, if you'd like.


# Description
A simple server implemeted with WEB API 2. Supports cors, data validation and session.

1. Interactive documentation of api is avaible on swagger page [/swagger/ui/index]

2. Two endpoints are exposed: 1. Get, 2. Post
   2.a Get for simple testing whether api is on and is alive
   2.b Post is to perform a bookmark operation
   

3. 2.b Expanded

  API :
  Has only 1 controller (Bookmark). 
  For Bookmarking use:

  POST :[server_root]/api/bookmark

  Model:
  Recieves as parameter
  {"id":int,"name":string ,"avatar": url (string),"identifier": string representing unique identifier}

  Implemented in /Models/BookmarkRequest.cs

  Response: HttpResponseMessage.


4. Data storage:

For each unique user represented by identifier field, stores dictionary of data where key is a unique identifier of repository and value is an object with name and avatar(url) properties.


5. For session support in api see /SessionHelpers and WebApi.config Register.

# Note
Possibly a better sollution was to use MVC project with api controller.
The solution has only one layer (no BLL, DAL or etc). 

