# Use the ubi8/dotnet-70-runtime base image
FROM ubi8/dotnet-70-runtime


# Copy the built application to the container
ADD bin/Debug/net7.0/publish/ .

# Set the entry point for the container
ENTRYPOINT ["dotnet", "HelloWorldAPI.dll"]
