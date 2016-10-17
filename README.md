# Greek nameday server

Nameday server hosts Greek anniversaries and all Holidays.

The available operations for consume are:

GetTodayAnniversaries
  Returns all anniversaries for today.
  
GetHolidays
  Returns the holidays for current year.
  
GetAnniversaries
  Returns all anniversaries for the specified year.
  Result can be filtered by first name

GetEaster
  Returns Easter's date for the specified year
  

The service has a WebHttpBinding and is listening at http://localhost:8080/namedays
and a NetTcpBinding listening at net.tcp://localhost/namedays
By typing http://localhost:8080/namedays/help you will be redirected to the client consume page which provides operation info.
