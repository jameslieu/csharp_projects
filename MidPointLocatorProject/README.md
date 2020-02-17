### MidPointLocatorProject

I created this project to automate finding all of the latitudes and longitudes from a list of postcodes and calculating the average to find the geographical midpoint. The end result is a console output that displays the latitude and longitude of the geographical midpoint as well as a URL link to the location on Google Maps.

![image](https://user-images.githubusercontent.com/4426088/74680057-7c083880-51b7-11ea-9718-534a87f3b03e.png)


For development I used a local instance of [postcodes.io](http://postcodes.io/) to query the postcode although this project does accept an environment variable `BULK_POSTCODE_LOOKUP_URL` if using the offical or a custom API endpoint is preferred

#### Prerequisites
Run docker compose command to prepare the API and DB to run local postcodes.io instance

```
docker-compose up -d
```

##### Note: when running this the first time, it will take a minute or so for the DB container to prepare the database before it can be queried.

Add the desired postcodes into the `assets/postcodes.txt` file.

Note: They will need to line separated i.e.
```
HA8 7AW
BR1 3NN
CR0 1LF
EN1 1YX
```

Then run the project:
```
dotnet run -p MidPointLocator
```
