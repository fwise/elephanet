###v0.3.9 - 2015-09-14

####Improvements
  -  Improvements for thread safety, including running tests in parallel and general test tidyup 

###v0.3.8 - 2015-09-09

####Improvements
  -  GetById behavior (throw vs. returnnull) is now configurable via StoreConventions

###v0.3.7 - 2015-08-31

####Improvements
  -  Modify the serializer to serialize dates to ISO8601 by default fixing https://github.com/YoloDev/elephanet/issues/19

###v0.3.6 - 2015-08-27

####Improvements
  -  Modify the serlializer to serialize inherit properties

###v0.3.5 - 2015-08-24

####Improvements
  -  Update time to timestamp (incorrectly implemented in past release)

###v0.3.4 - 2015-08-24

####Improvements
  -  Create time by default at UTC, picked up by Frank Wise (https://github.com/fwise)

###v0.3.3 - 2015-08-24

####Improvements
  - Extract ITableInfo and inject into StoreConventions to allow overriding of table naming conventions with thanks to Frank Wise (https://github.com/fwise)

###v0.3.2 - 2015-08-23
####New Features
 - Add sql script for easy creation of data store database
 - Add bat file for running on windows to run sql script previously mentioned

####Improvements
  - Updated readme

###v0.3.1 - 2015-04-22
####New Features
 - Add support for .OrderBy() and .OrderByDescending()
 - Add support for .Skip() and .Take()
 - Add release-notes.md

####Improvements
  - Updated readme
