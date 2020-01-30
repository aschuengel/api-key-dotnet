# Sample script to test api key 
curl -v https://localhost:5001/weatherforecast/ -H "X-Api-Key: {14739a8a-b3f2-4f6e-8af4-0b8933586239}"
curl -v https://localhost:5001/weatherforecast/ -H "X-Api-Key: 14739a8a-b3f2-4f6e-8af4-0b8933586239"
curl -v https://localhost:5001/weatherforecast/ -H "X-Api-Key: huhu"
curl -v https://localhost:5001/weatherforecast/
# EOF