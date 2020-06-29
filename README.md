# NewsPublisher
Path to solution file
NewsPublisher\NewsPublisher.sln

# Notes 
1. Used .net core web api  
2. Used Microsoft clean architecture to solve problem statement 
3. Added swagger for api testing
4. Only two api's are added RegisterNewsSource and GetNewsContents
5. ModelService invoke all the providers
3. News sources are stored in json file, new news source will be added to same file (NewsPublisher\NewsProviders.json)
4. If new news source added then application start communication to added provider data will start flowing if interface implemented.
5. Next news items will picked up if pageid is being pass in query string http://localhost:64567/News?pageid=2

# Assumptions
1. If all 8 news items are top news no ad will be added for one page
2. All news providers data mocked inside implemented class
3. Advertisement data mocked in implemented class
4. Writing to NewsProviders.json file is done using IDataAccess  
