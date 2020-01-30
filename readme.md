## Sample project to show the integration of API key authentication into a .Net COre 3.1 project

Creedits to https://josefottosson.se/asp-net-core-protect-your-api-with-api-keys/

# ApiKeyAuthenticationHandler.cs

Implements the middleware service to check for the X-Api-Key and valdate it's value

# GetApiKeyQuery.cs

Retrieve the API key based on the header value

# Controllers/WeatherForecastController.cs

Basic controller. Note the `[Authorized]` attribute

# curl.sh

Example script to test the API key feature

# ApiKey.cs

Implementation of an API key. May be simplified?