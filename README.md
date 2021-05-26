What is the ADF.NoSQL Project?
=====================
The ADF.NoSQL Project is a demo project created using using ASP.NET Core MVC and MongoDB.

The goal of this project is to get hands on the Mongo Db. This application is managing a database of cars and its maing page will look like this.

![Home Page](https://i.ibb.co/mFw4MjN/1-7m-ESZVq-Oxlf8-WEE7-Vr-Yg-A.png)

## How to use:
- You will need the the IDE of your own choice Visual Studio 2019 and Mongo DB.
### MongoDB Installation and Configuration

I am using Windows 10 so I will give the instructions for Windows.

1. Go to this [site](https://www.mongodb.com/download-center/community) and download MongoDB for your OS version.
2. MongoDB is installed at C:\Program Files\MongoDB by default. In the C:\Program Files\MongoDB\Server\{version_number}\bin folder there are two executables: mongod and mongo.
3. Go to Control Panel -> System -> Advanced System Settings -> Environment Variables and edit Path variable and add C:\Program Files\MongoDB\Server\{version_number}\bin to that. This change enables MongoDB access from anywhere on your machine.
4. MongoDB’s default directory for data storage is /data/db. Create these directories in your C drive.
5. Open a command prompt and run the following command.
```
mongod
```
6. Open a new command prompt and run the below command:
```
mongo
```
We will run all our mongo shell methods in this command shell.
7.  Run the following command:
```
use CarGalleryDb
```
This command creates the database if it does not exist. If it exists, its connection is opened for transactions.
8. Create a Cars collection using the following command:
```
db.createCollection('Cars')
```

Now, our database and collection are ready. We can perform CRUD operations on the Cars collection.




