# NewsPublisher
Path to solution file
NewsPublisher\NewsPublisher.sln

# Notes 
1. Used .net core web api  
2. Used Microsoft clean architecture to solve problem statement 
3. News sources are stored in json file, new news source will be added to same file (NewsPublisher\NewsProviders.json)
4. If new news source added then application start to communicate to the provider if interface is implemented.
5. Next news items will picked up if pageid is being pass in query string http://localhost:64567/News?pageid=2

# Assumptionsssumptions 
1. If all 8 news items are top news no ad will be added
2. News advertisment ration also add as 3/1 or 1/1
