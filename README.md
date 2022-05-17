# RobotPayloadAPI

Instructions: \
1: Open RobotAPI.sln in visual studio. Build project and run. Make sure ASP.NET web development is installed. \
2: Submit a post request on Postman to https://localhost:5000/api/robots/closest/, make sure Verify SSL certificates is turned off in postman settings. Under "body" enter the argument to supply for the post request. Ex. \
\
{\
    "loadId": 214,\
    "x": 24,\
    "y": 15\
}  \
\
Make sure "raw" is checked and JSON is selected when entering the post argument. \
\
2 (alternative): Go to to https://localhost:5000/swagger. This should give a good overview of the API. Expand the Post request type listed (/api/robots/closest). Click "Try it out" and execute a post request with a payload. Look at "Server response" section for the returned value. \
\
Next Steps:\
Ideally we would save all the Payloads into a database and when sending a post request we could supply the loadID only, retrieve the payload coords from the database, and return the closest robot/payload assignment. Also the API should return whether a robot is occupied with a load, if it is, it should be excluded from the closest calculations. 
