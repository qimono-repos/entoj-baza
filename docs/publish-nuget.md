# PUBLISH TO NUGET.ORG

dotnet pack 

dotnet nuget push <YOUR_PACKAGE_PATH> --source https://api.nuget.org/v3/index.json --api-key <YOUR_API_KEY>

