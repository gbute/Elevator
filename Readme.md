Elevator Service
============
This is an api to serve up information needed by an elevator application.  Four APIs are supported, namely:

 1. A person requests an elevator be sent to their current floor.
		
		Example:
		GET http://localhost:8080/elevatorfloors/5/request

 2. A person requests that they be brought to a floor.
		
		Example:
		PUT http://localhost:8080/elevatorfloors/3/bring

 3. An elevator car requests all floors that its current passengers are servicing.
		
		Example:
		GET http://localhost:8080/elevatorfloors/current

 4. An elevator car requests the next floor it needs to service.

		Example:
		GET http://localhost:8080/elevatorfloors/next

See http://localhost:8080/elevatorfloors for the service base.

Swagger Docs:
http://localhost:8080/swagger/index.html

To run the app, goto directory with Elevator.sln in it, and issue this command:

	dotnet run ./Elevator.sln
